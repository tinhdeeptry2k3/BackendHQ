using BusinessLogicLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class AccountsBusiness : IAccountsBusiness
    {
        private IAccountsRepository _res;
        public AccountsBusiness(IAccountsRepository res)
        {
            _res = res;
        }

        public Accounts GetAccountsAll()
        {
            return _res.GetAllAccounts();
        }

    }
}
