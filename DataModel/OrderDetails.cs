using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class OrderDetails
    {
        public int id { get; set; }
        public int order_id { get; set; }
        public int product_id { get; set; }
        public int quantity { get; set; }
    }
}
