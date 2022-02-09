using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon.BL.Concrete
{
    using Abstract;
    using DAL.Concrete;
    using DAL.Abstract;
    using DAL.Context;

    public class ShipperBusiness : IShipperBusiness
    {
        IShipperRepo shipperRepo;

        public ShipperBusiness()
        {
            shipperRepo = new ShipperRepo();
        }

        public void Add(Shipper item)
        {
            shipperRepo.Add(item);
        }

        public bool Delete(int id)
        {
            return shipperRepo.Delete(id);
        }

        public List<Shipper> Get()
        {
            return shipperRepo.Get();
        }

        public Shipper GetById(int id)
        {
            return shipperRepo.GetById(id);
        }

        public void Update(Shipper item)
        {
            shipperRepo.Update(item);
        }
    }
}
