﻿using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using DataAccessLayer.Helper;

namespace DataAccessLayer
{
    public class OrderRepository : IOrderRepository
    {
        private IDatabaseHelper _dbHelper;
        private IProductsRepository _productsRepository;
        private Tool tool;
        public OrderRepository(IDatabaseHelper dbHelper,IProductsRepository productsRepository)
        {
            _dbHelper = dbHelper;
            _productsRepository = productsRepository;
            tool = new Tool();
        }

        public string Insert(List<OrderProductModel> lstProducts, Orders orders,string username)
        {
            try
            {
                if(lstProducts.Count == 0)
                {
                    return "no_item_in_order";
                }

                if(username == orders.username)
                {
                    return "username_false";
                }

                var orderCode = tool.RandomText(10);


                var result = _dbHelper.ExecuteNoneQuery(String.Format("INSERT INTO Orders (id,username,address,phone,status) VALUES ('{0}','{1}','{2}','{3}','{4}')",orderCode, username, orders.address, orders.phone, "Đang xử lý"));
                
                if(!string.IsNullOrEmpty(result))
                {
                    return "create_order_error";
                }

                foreach(var item in lstProducts)
                {
                    Products product = _productsRepository.GetById(item.id.ToString());

                    if(product == null)
                    {
                        continue;
                    }
                    if(item.quantity > product.quantity)
                    {
                        continue;
                    }

                    result = _dbHelper.ExecuteNoneQuery(String.Format("INSERT INTO OrderDetails (order_id,product_id,product_name,quantity,image,total_price) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", orderCode, product.id, product.name, item.quantity, product.image, item.quantity * product.price));
                    if(string.IsNullOrEmpty(result))
                    {
                        _dbHelper.ExecuteNoneQuery(String.Format("UPDATE Products SET quantity = '{0}' WHERE id = '{1}'", product.quantity - item.quantity, product.id));
                    }
                    
                }
                return "create_order_success";

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
