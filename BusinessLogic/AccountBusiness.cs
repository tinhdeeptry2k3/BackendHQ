using BusinessLogic.Interfaces;
using DataAccess;
using DataModel;

namespace BusinessLogic
{
    public class AccountBusiness : IAccountsBusiness
    {
        private IAccountsBusiness _accountsRepository;

        public AccountBusiness(IAccountsBusiness accountsRepository)
        {
            _accountsRepository = accountsRepository;
        }

        public Accounts GetAccountsAll()
        {
            return _accountsRepository.GetAccountsAll();
        }
    }
}