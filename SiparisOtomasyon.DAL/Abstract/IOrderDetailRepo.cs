using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon.DAL.Abstract
{
    using DAL.Context;
    using SiparisOtomasyon.DAL.VM;

    public interface IOrderDetailRepo
    {
        void Add(Order_Detail item);
        void Update(Order_Detail item);
        List<Order_Detail> Get(int orderId);
        Order_Detail GetById(int orderId, int productId);
        bool Delete(int orderId, int productId);
        List<OrderDetailVM> GetOrderDetailVMs(int id);
        bool Delete(int orderId);
    }
}
