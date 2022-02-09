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

    public class OrderRepo : IOrderRepo
    {
        private NorthwindContext DB;

        public OrderRepo()
        {
            DB = new NorthwindContext();
        }

        public void Add(Order item)
        {
            DB.Orders.Add(item);
            DB.SaveChanges();
        }

        public bool Delete(int id)
        {
            var dbItem = DB.Orders.FirstOrDefault(t0 => t0.OrderID == id);
            if (dbItem != null)
            {
                DB.Orders.Remove(dbItem);
                DB.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Order> Get()
        {
            return DB.Orders.AsNoTracking().ToList();
        }

        public Order GetById(int id)
        {
            return DB.Orders.FirstOrDefault(t0 => t0.OrderID == id);
        }

        public List<OrderDetailVM> GetOrderDetailVMs(int id)
        {
            var orderDetails = (from t0 in DB.Order_Details
                                where t0.OrderID==id
                                select new OrderDetailVM()                                
                                {
                                    OrderId = t0.OrderID,
                                    ProductName = t0.Product.ProductName,
                                    UnitPrice =t0.UnitPrice,
                                    Quantity = t0.Quantity,
                                    Discount = t0.Discount
                                }).ToList();
            return orderDetails;
        }

        public List<OrderVM> GetOrderVMs()
        {
            var orders = (from t0 in DB.Orders
                            select new OrderVM()
                            {
                                OrderId = t0.OrderID,
                                CompanyName=t0.Customer.CompanyName,
                                EmployeeNameAndSurname=t0.Employee.FirstName+" "+t0.Employee.LastName,
                                OrderDate=t0.OrderDate

                            }).ToList();
            return orders;
        }


        public void Update(Order item)
        {
            DB.Entry(item).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
