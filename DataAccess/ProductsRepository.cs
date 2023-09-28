using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Interfaces;
using DataModel;

namespace DataAccessLayer
{
    public class ProductsRepository : IProductsRepository
    {
        private IDatabaseHelper _dbHelper;
        public ProductsRepository(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        public bool Insert(Products products)
        {
            string msgErr = "";
            try
            {
                var sql = String.Format("SELECT * FROM Categorys WHERE id = '{0}'",products.category_id);
                var row = _dbHelper.ExecuteQueryToDataTable(sql, out msgErr);
                if (row.ConvertTo<Accounts>().FirstOrDefault() != null)
                {
                    return false;
                }
                sql = String.Format("INSERT INTO Products(name,price,quantity,description,category_id,image) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", products.name,products.price,products.quantity,products.description,products.category_id,products.image);
                _dbHelper.ExecuteNoneQuery(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Products products)
        {
            try
            {
                var sql = String.Format("UPDATE Products SET name = '{0}',price = '{1}',quantity = '{2}',description = '{3}',category_id = '{4}',image = {5} WHERE id = {6}", products.name,products.price,products.quantity,products.description,products.category_id,products.image,products.id);
                _dbHelper.ExecuteNoneQuery(sql); return true;
            }
            catch { return false; }
        }

        public bool Delete(string id)
        {
            try
            {
                var sql = String.Format("DELETE FROM Products WHERE id = {0}", id);
                _dbHelper.ExecuteNoneQuery(sql); return true;
            }
            catch { return false; }
        }

        public List<Products> GetList()
        {
            try
            {
                string msgErr = "";
                var sql = "SELECT * FROM Products";
                var data = _dbHelper.ExecuteQueryToDataTable(sql, out msgErr);
                return data.ConvertTo<Products>().ToList();
            }
            catch
            {
                return null;
            }
        }

        public Products GetById(string id)
        {
            string msgErr = "";
            try
            {
                var sql = String.Format("SELECT * FROM Products WHERE id = '{0}'", id);
                var data = _dbHelper.ExecuteQueryToDataTable(sql, out msgErr);
                return data.ConvertTo<Products>().FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }

    }
}
