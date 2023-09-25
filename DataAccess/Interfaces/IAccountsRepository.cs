using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public partial interface IAccountsRepository
    {
        public Accounts GetAccountsAll();
    }
}
