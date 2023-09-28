using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace DataAccessLayer.Interfaces
{
    public class CategorysReposity : ICategorysRepository
    {
        private IDatabaseHelper _dbHelper;
        public CategorysReposity(IDatabaseHelper iDatabaseHelper)
        {
            _dbHelper = iDatabaseHelper;
        }

        public bool Insert(Categorys categorys)
        {
            try
            {
                var sql = String.Format("INSERT INTO Categorys(name) VALUES ('{0}')", categorys.name);
                _dbHelper.ExecuteNoneQuery(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Categorys categorys)
        {
            try
            {
                var sql = String.Format("UPDATE Categorys SET name = '{0}' WHERE id = {1}", categorys.name, categorys.id);
                _dbHelper.ExecuteNoneQuery(sql); return true;
            }
            catch { return false; }
        }

        public bool Delete(string id )
        {
            try
            {
                var sql = String.Format("DELETE FROM Categorys WHERE id = {0}", id);
                _dbHelper.ExecuteNoneQuery(sql); return true;
            }
            catch { return false; }
        }

        public List<Categorys> GetList()
        {
            try
            {
                string msgErr = "";
                var sql = "SELECT * FROM Categorys";
                var data = _dbHelper.ExecuteQueryToDataTable(sql,out msgErr);
                return data.ConvertTo<Categorys>().ToList();
            }
            catch
            {
                return null;
            }
        }
    }
}
