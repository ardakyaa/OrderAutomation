using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon.DAL.Abstract
{
    using Abstract;
    using Context;
    public interface ICategoryRepo : IRepository<Category,int>
    {

    }
}
