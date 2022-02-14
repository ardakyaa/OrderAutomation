using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon.BL.Concrete
{
    using Abstract;
    using DAL.Abstract;
    using DAL.Concrete;
    using DAL.Context;
    using SiparisOtomasyon.DAL.VM;

    public class OrderBusiness : IOrderBusiness
    {
        private IOrderRepo orderRepo;

        public OrderBusiness()
        {
            orderRepo = new OrderRepo();
        }

        public void Add(Order item)
        {
            orderRepo.Add(item);
        }

        public bool Delete(int id)
        {
            return orderRepo.Delete(id);
        }

        public List<Order> Get()
        {
            return orderRepo.Get();
        }

        public Order GetById(int id)
        {
            return orderRepo.GetById(id);
        }

        public List<OrderVM> GetOrderVMs()
        {
            return orderRepo.GetOrderVMs();
        }

        public void Update(Order item)
        {
            orderRepo.Update(item);
        }
    }
}
