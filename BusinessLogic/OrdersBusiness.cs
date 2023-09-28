using BusinessLogicLayer.Interfaces;
using DataAccessLayer.Interfaces;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class OrdersBusiness : IOrdersBusiness
    {
        private IOrderRepository _res;
        public OrdersBusiness(IOrderRepository res)
        {
            _res = res;
        }
        public string Insert(List<OrderProductModel> lstProducts, Orders orders, string username)
        {
            return _res.Insert(lstProducts, orders, username);
        }
    }
}
