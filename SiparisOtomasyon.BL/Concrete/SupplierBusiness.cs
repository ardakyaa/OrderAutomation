using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon.BL.Concrete
{
    using Abstract;
    using DAL.Context;
    using DAL.Concrete;
    using DAL.Abstract;

    public class SupplierBusiness : ISupplierBusiness
    {
        ISupplierRepo supplierRepo;

        public SupplierBusiness()
        {
            supplierRepo = new SupplierRepo();
        }
        public void Add(Supplier item)
        {
            supplierRepo.Add(item);
        }

        public bool Delete(int id)
        {
            return supplierRepo.Delete(id);
        }

        public List<Supplier> Get()
        {
            return supplierRepo.Get();
        }

        public Supplier GetById(int id)
        {
            return supplierRepo.GetById(id);
        }

        public void Update(Supplier item)
        {
            supplierRepo.Update(item);
        }
    }
}
