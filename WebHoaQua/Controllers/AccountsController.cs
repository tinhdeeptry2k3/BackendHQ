using BusinessLogicLayer.Interfaces;
using DataModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebHoaQua.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private IAccountsBusiness _accountsBusiness;

        public AccountsController(IAccountsBusiness accountsBusiness)
        {
            _accountsBusiness = accountsBusiness;
        }

        [Route("getaccounts")]
        [HttpGet]
        public Accounts GetAccountsAll()
        {
            return _accountsBusiness.GetAccountsAll();
        }
    }

    
}
