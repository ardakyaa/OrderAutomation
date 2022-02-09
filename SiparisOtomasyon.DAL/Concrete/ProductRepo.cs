using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon.DAL.Concrete
{
    using Abstract;
    using SiparisOtomasyon.DAL.Context;
    using SiparisOtomasyon.DAL.VM;

    public class ProductRepo : IProductRepo
    {
        private NorthwindContext DB;

        public ProductRepo()
        {
            DB = new NorthwindContext();
        }

        public void Add(Product item)
        {
            DB.Products.Add(item);
            DB.SaveChanges();
        }

        public bool Delete(int id)
        {
            var dbItem = DB.Products.FirstOrDefault(t0 => t0.ProductID == id);
            if (dbItem != null)
            {
                DB.Products.Remove(dbItem);
                DB.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Product> Get()
        {
            return DB.Products.AsNoTracking().ToList();
        }

        public Product GetById(int id)
        {
            return DB.Products.FirstOrDefault(t0 => t0.ProductID == id);
        }

        public List<ProductVM> GetProductsVM()
        {
            var products = (from t0 in DB.Products
                            select new ProductVM()
                            {
                                ProductId = t0.ProductID,
                                ProductName = t0.ProductName,
                                CategoryName = t0.Category.CategoryName,
                                CompanyName = t0.Supplier.CompanyName,
                                UnitPrice = t0.UnitPrice,
                                UnitsInStock = t0.UnitsInStock
                            }).ToList();
            return products;
        }

        public void Update(Product item)
        {
            DB.Entry(item).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
