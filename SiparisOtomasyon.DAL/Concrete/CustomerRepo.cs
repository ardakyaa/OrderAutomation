using SiparisOtomasyon.DAL.Abstract;
using SiparisOtomasyon.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon.DAL.Concrete
{
    public class CustomerRepo : ICustomerRepo
    {
        private NorthwindContext DB;

        public CustomerRepo()
        {
            DB = new NorthwindContext();
        }

        public void Add(Customer item)
        {
            DB.Customers.Add(item);
            DB.SaveChanges();
        }

        public bool Delete(string id)
        {
            var dbItem = DB.Customers.FirstOrDefault(t0 => t0.CustomerID == id);
            if (dbItem!=null)
            {
                DB.Customers.Remove(dbItem);
                DB.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
           
        }

        public List<Customer> Get()
        {
            return DB.Customers.AsNoTracking().ToList();
        }

        public Customer GetById(string id)
        {
            return DB.Customers.FirstOrDefault(t0 => t0.CustomerID == id);
        }

        public void Update(Customer item)
        {
            DB.Entry(item).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
