using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon.DAL.Concrete
{
    using Abstract;
    using Context;
    using SiparisOtomasyon.DAL.VM;

    public class EmployeeRepo : GenericRepo<Employee, int>, IEmployeeRepo
    {
        NorthwindContext DB;

        public EmployeeRepo()
        {
            DB = new NorthwindContext();
        }

        public List<EmployeeVM> GetEmployeeVMs()
        {
            var employees = (from t0 in DB.Employees
                             select new EmployeeVM()
                             {
                                 EmployeeId = t0.EmployeeID,
                                 EmployeeNameAndSurname = t0.FirstName + " " + t0.LastName,
                             }).ToList();
            return employees;
        }
    }
}
