using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon.DAL.VM
{
    public class OrderDetailVM
    {
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }
        /// <summary>
        /// Satır Toplamı
        /// </summary>
        public decimal Total 
        {
            get
            {
                return UnitPrice * Quantity * (1 - Convert.ToDecimal(Discount));
            }
        }

    }
}
