using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon.BL.Concrete
{
    using DAL.Abstract;
    using Abstract;
    using DAL.Concrete;
    using DAL.Context;
    using SiparisOtomasyon.DAL.VM;

    public class OrderDetailBusiness : IOrderDetailBusiness
    {
        IOrderDetailRepo orderDetailRepo;

        public OrderDetailBusiness()
        {
            orderDetailRepo = new OrderDetailRepo();
        }

        public void Add(Order_Detail item)
        {
            orderDetailRepo.Add(item);
        }

        public bool Delete(int orderId, int productId)
        {
            return orderDetailRepo.Delete(orderId, productId);
        }

        public bool Delete(int orderId)
        {
            return orderDetailRepo.Delete(orderId);
        }

        public List<Order_Detail> Get(int orderId)
        {
            return orderDetailRepo.Get(orderId);
        }

        public Order_Detail GetById(int orderId, int productId)
        {
            return orderDetailRepo.GetById(orderId, productId);
        }

        public List<OrderDetailVM> GetOrderDetailVMs(int id)
        {
            return orderDetailRepo.GetOrderDetailVMs(id);
        }

        public void Update(Order_Detail item)
        {
            orderDetailRepo.Update(item);
        }
    }
}
