using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace DataAccessLayer.Interfaces
{
    public partial interface IOrderRepository
    {
        string Insert(List<OrderProductModel> lstProducts,Orders orders,string username);
    }
}
