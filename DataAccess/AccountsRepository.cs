using DataAccessLayer;
using DataModel;

namespace DataAccessLayer
{
    public class AccountsRepository: IAccountsRepository
    {
        private IDatabaseHelper _dbHelper;
        public AccountsRepository(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        public Accounts GetAllAccounts()
        {
            string msgError = "";
            var dt = _dbHelper.ExecuteQueryToDataTable("SELECT * FROM Accounts", out msgError);
            return dt.ConvertTo<Accounts>().FirstOrDefault();
        }

    }
}
