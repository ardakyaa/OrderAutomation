using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon.DAL.VM
{
    public class OrderVM
    {
        public int OrderId { get; set; }
        public string CompanyName { get; set; }
        public string EmployeeName { get; set; }
        public DateTime? OrderDate { get; set; }
    }
}
