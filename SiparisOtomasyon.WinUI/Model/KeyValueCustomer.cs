using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon.WinUI.Model
{
    public class KeyValueCustomer<TData>
    where TData : class
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public TData Data { get; set; }
    }
}
