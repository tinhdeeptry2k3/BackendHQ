using DataAccess.Interfaces;
using DataAccessLayer;
using DataModel;


namespace DataAccess
{
    public class AccountsRepository : IAccountsRepository
    {
        private IDatabaseHelper _databaseHelper;

        public AccountsRepository(IDatabaseHelper databaseHelper)
        {
            _databaseHelper = databaseHelper;
        }

        public Accounts GetAccountsAll()
        {
            string msgError = "";
            try
            {
                var dt = _databaseHelper.ExecuteQueryToDataTable("SELECT * FROM Accounts", out msgError);
                return dt.ConvertTo<Accounts>().FirstOrDefault();
            }   
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
