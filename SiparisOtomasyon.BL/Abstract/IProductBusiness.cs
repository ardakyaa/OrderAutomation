using SiparisOtomasyon.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon.BL.Abstract
{
    using DAL.Context;
    using DAL.VM;
    public interface IProductBusiness : IBusiness<Product,int>
    {
        List<ProductVM> GetProductsVM();
    }
}
