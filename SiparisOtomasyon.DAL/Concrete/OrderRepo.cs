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

    public class OrderRepo : GenericRepo<Order,int>, IOrderRepo
    {

        public List<OrderVM> GetOrderVMs()
        {
            var orders = (from t0 in DB.Orders
                            select new OrderVM()
                            {
                                OrderId = t0.OrderID,
                                CompanyName=t0.Customer.CompanyName,
                                EmployeeName=t0.Employee.FirstName+" "+t0.Employee.LastName,
                                OrderDate=t0.OrderDate

                            }).ToList();
            return orders;
        }


    }
}
