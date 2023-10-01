﻿using DataAccessLayer.Interfaces;
using DataModel;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Security.Principal;

namespace DataAccessLayer
{
    public class UserRepository : IUserRepository
    {
        private IDatabaseHelper _dbHelper;
        public UserRepository(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }
        public Accounts Login(string taikhoan, string matkhau)
        {
            //string msgError = "";


            //try
            //{
            //    var sql = String.Format("SELECT * FROM Accounts WHERE username = '{0}' AND password = '{1}'", taikhoan, matkhau);
            //    var dt = _dbHelper.ExecuteQueryToDataTable(sql, out msgError);
            //    return dt.ConvertTo<Accounts>().FirstOrDefault();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_login",
                "@username", taikhoan,
                "@password", matkhau);
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return result.ConvertTo<Accounts>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool Register(string username, string password)
        {
            //string msgErr = "";
            //try
            //{
            //    var sql = String.Format("SELECT * FROM Accounts WHERE username = '{0}' AND password = '{1}'", username, password);
            //    var row = _dbHelper.ExecuteQueryToDataTable(sql, out msgErr);
            //    if(row.ConvertTo<Accounts>().FirstOrDefault() != null)
            //    {
            //        return false;
            //    }

            //    sql = String.Format("INSERT INTO Accounts (username,password,level,money,address,phone,fullname) VALUES ('{0}','{1}','user',0,'','','')", username, password);
            //    _dbHelper.ExecuteNoneQuery(sql);
            //    return true;
            //}
            //catch(Exception ex)
            //{
            //    return false;
            //}

            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_register",
                "@username", username,
                "@password", password);
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(string fullname, string address, string phone,string username)
        {
            //try
            //{
            //    var sql = String.Format("UPDATE Accounts SET fullname = '{0}', address = '{1}', phone = '{2}' WHERE username = '{3}'",fullname,address,phone,username);
            //    _dbHelper.ExecuteNoneQuery(sql);
            //    return true;
            //}
            //catch(Exception ex)
            //{
            //    return false;
            //}
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_update_accounts",
                "@fullname", fullname,
                "@address", address,
                "@phone", phone,
                "@username", username);
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
