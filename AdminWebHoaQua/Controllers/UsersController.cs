using BusinessLogicLayer;
using DataModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebHoaQua.Controllers
{
    [Authorize(Roles = "admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserBusiness _userBusiness;

        public UsersController(IUserBusiness userBusiness)
        {
            _userBusiness = userBusiness;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Login([FromBody] AuthenticateModel model)
        {
            var user = _userBusiness.Login(model.Username, model.Password);
            if (user == null)
                return Ok(new
                {
                    status = false,
                    message = "Tài khoản hoặc mật khẩu không chính xác !"
                });

            return Ok(new
            {
                status = true,
                username = user.username,
                token = user.token
            });
        }

        [HttpPost("checkaccount")]
        public IActionResult CheckAccounts()
        {
            return Ok(new
            {
                status = true
            });
        }

        [HttpPost("getlist")]
        public IActionResult GetList()
        {
            var result = _userBusiness.GetAll();
            return Ok(new
            {
                result
            });
        }

        [HttpPost("delete/{id}")]
        public IActionResult DeleteByID(string id)
        {
            var result = _userBusiness.DeleteById(id);
            return Ok(new
            {
                status = result
            });
        }

        [HttpPost("update")]
        public IActionResult Update([FromBody] UpdateModelByAdmin model)
        {
            bool update = _userBusiness.UpdateByAdmin(model);
            if (update)
            {
                return Ok(new
                {
                    status = true,
                    message = "Cập nhật thông tin thành công!"
                });
            }
            else
            {
                return Ok(new
                {
                    status = false,
                    message = "Cập nhật thông tin thất bại!"
                });
            }
        }
    }
}
