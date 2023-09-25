using DataAccessLayer.Interfaces;
using DataModel;
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
            string msgError = "";

            
            try
            {
                var sql = String.Format("SELECT * FROM Accounts WHERE username = '{0}' AND password = '{1}'", taikhoan, matkhau);
                var dt = _dbHelper.ExecuteQueryToDataTable(sql, out msgError);
                return dt.ConvertTo<Accounts>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
