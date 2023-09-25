using BusinessLogicLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using DataAccessLayer;
using Microsoft.Extensions.Configuration;

namespace BusinessLogicLayer
{
    public class AccountsBusiness : IAccountsBusiness
    {
        private IAccountsRepository _res;
        private IConfiguration _configuratrion;
        public AccountsBusiness(IAccountsRepository res, IConfiguration configuration)
        {
            _res = res;
            _configuratrion = configuration;
        }

        public Accounts GetAccountsAll()
        {
            return _res.GetAllAccounts();
        }

    }
}
