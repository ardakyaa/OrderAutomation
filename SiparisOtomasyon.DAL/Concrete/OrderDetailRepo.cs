using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon.DAL.Concrete
{
    using Abstract;
    using Context;
    using SiparisOtomasyon.DAL.VM;

    public class OrderDetailRepo : IOrderDetailRepo
    {
        NorthwindContext DB;
        public OrderDetailRepo()
        {
            DB = new NorthwindContext();
        }
        public void Add(Order_Detail item)
        {
            DB.Entry(item).State = System.Data.Entity.EntityState.Added;
            DB.SaveChanges();
        }

        public bool Delete(int orderId, int productId)
        {
            var orderDetail = DB.Order_Details.FirstOrDefault(t0 => t0.OrderID == orderId && t0.ProductID == productId);
            if (orderDetail!=null)
            {
                DB.Entry(orderDetail).State = System.Data.Entity.EntityState.Deleted;
                DB.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Delete(int orderId)
        {            
            var orderDetails = DB.Order_Details.Where(t0 => t0.OrderID == orderId).ToList();
            if(orderDetails!=null)
            {
                foreach (var item in orderDetails)
                {
                    DB.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                }
                DB.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }

        //Ödev => IQueryable, Expression, Func araştır!!!!!!!!!!!!!!!!!!!!!
        public List<Order_Detail> Get(int orderId)
        {
            return DB.Order_Details.Where(t0 => t0.OrderID == orderId).ToList();
        }

        public Order_Detail GetById(int orderId, int productId)
        {
            return DB.Order_Details.FirstOrDefault(t0 => t0.OrderID == orderId && t0.ProductID == productId);
        }

        public List<OrderDetailVM> GetOrderDetailVMs(int id)
        {
            var orderDetails = (from t0 in DB.Order_Details
                                where t0.OrderID == id
                                select new OrderDetailVM()
                                {
                                    OrderId = t0.OrderID,
                                    ProductName = t0.Product.ProductName,
                                    ProductId = t0.ProductID,
                                    UnitPrice = t0.UnitPrice,
                                    Quantity = t0.Quantity,
                                    Discount = t0.Discount
                                    
                                }).ToList();
            return orderDetails;
        }

        public void Update(Order_Detail item)
        {
            DB.Entry(item).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
