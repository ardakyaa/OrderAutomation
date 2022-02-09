using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon.BL.Concrete
{
    using Abstract;
    using DAL.Context;
    using DAL.Abstract;
    using DAL.Concrete;

    public class CategoryBusiness : ICategoryBusiness
    {
        
        ICategoryRepo categoryRepo;
        public CategoryBusiness()
        {
            categoryRepo = new CategoryRepo();
        }
        public void Add(Category item)
        {
            categoryRepo.Add(item);
        }

        public bool Delete(int id)
        {
            return categoryRepo.Delete(id);
        }

        public List<Category> Get()
        {
            return categoryRepo.Get();
        }

        public Category GetById(int id)
        {
            return categoryRepo.GetById(id);
        }

        public void Update(Category item)
        {
            categoryRepo.Update(item);
        }
    }
}
