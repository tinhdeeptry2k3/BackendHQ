using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessLogicLayer;
using BusinessLogicLayer.Interfaces;
using DataModel;
using Microsoft.AspNetCore.Authorization;

namespace WebHoaQua.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private IOrdersBusiness ordersBusiness;
        public OrdersController(IOrdersBusiness ordersBusiness)
        {
            this.ordersBusiness = ordersBusiness;
        }

        [HttpPost("insert")]
        public IActionResult Insert(CreateOrderModel createOrderModel)
        {

            var result = ordersBusiness.Insert(createOrderModel.listProducts, createOrderModel.orders, User.Identity.Name);
            return Ok(new
            {
                message = result,
            });
        }
    }
}
