using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon.DAL.Abstract
{
    using Context;
    using VM;
    public interface IEmployeeRepo : IRepository<Employee,int>
    {
        List<EmployeeVM> GetEmployeeVMs();
    }
}
