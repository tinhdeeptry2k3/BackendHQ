using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace DataAccessLayer.Interfaces
{
    public partial interface IUserRepository
    {
        Accounts Login(string username, string password);
    }
}
