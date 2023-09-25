using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessLogic;
using DataModel;
using BusinessLogic.Interfaces;

namespace WebHoaQua.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private IAccountsBusiness _accountBusiness;
        public AccountsController(IAccountsBusiness accountBusiness) 
        {
            _accountBusiness = accountBusiness;
        }

        [Route("getaccounts")]
        [HttpGet]
        public Accounts GetAccountsAll()
        {
            return _accountBusiness.GetAccountsAll();
        }
    }

    
}
