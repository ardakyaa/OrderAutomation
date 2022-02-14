using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisOtomasyon.WinUI.Helper
{
    
    using Model;
    public static class UIExtension
    {
        public static void SetDataSourceFirstItems<TValue,TData>(this ComboBox combo, IEnumerable<TData> datasource, string displayMember, string valueMember, string firstItemText)
            where TValue : struct 
            where TData : class
        {
            List<KeyValue<TValue, TData>> newDatasources = new List<KeyValue<TValue, TData>>();
            newDatasources.Add(new KeyValue<TValue, TData>() { Key = firstItemText, Value=null, Data = null });

            //REFLECTION ARAŞTIR!!!!!!!!!!!!!!!!!!!!!!!!!!
            foreach (var item in datasource)
            {
                var key = (string)item.GetType().GetProperty(displayMember).GetValue(item);
                var value = (TValue)item.GetType().GetProperty(valueMember).GetValue(item);

                newDatasources.Add(new KeyValue<TValue, TData>() { Key = key, Value = value, Data = item });
            }

            combo.DataSource = newDatasources;
            combo.DisplayMember = "Key";
            combo.ValueMember = "Value";

        }

        public static void SetCustomerFirstItems<TData>(this ComboBox combo, IEnumerable<TData> datasource, string displayMember, string valueMember, string firstItemText)
            where TData : class
        {
            List<KeyValueCustomer<TData>> newDatasources = new List<KeyValueCustomer<TData>>();
            newDatasources.Add(new KeyValueCustomer<TData>() { Key = firstItemText, Value = null, Data = null });

            foreach (var item in datasource)
            {
                var key = (string)item.GetType().GetProperty(displayMember).GetValue(item);
                var value = (string)item.GetType().GetProperty(valueMember).GetValue(item);

                newDatasources.Add(new KeyValueCustomer<TData>() { Key = key, Value = value, Data = item });
            }

            combo.DataSource = newDatasources;
            combo.DisplayMember = "Key";
            combo.ValueMember = "Value";

        }

        /// <summary>
        /// Combobox üzerinde eğer bir datasource atanmış ise bu method ile unboxing yapmadan değeri geri okuyabilirim.
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <typeparam name="TData"></typeparam>
        /// <param name="combo"></param>
        /// <returns></returns>
        public static TValue? GetValue<TValue, TData>(this ComboBox combo)
            where TValue : struct
            where TData : class
        {
            return ((combo.DataSource as List<KeyValue<TValue, TData>>)[combo.SelectedIndex]).Value;
        }

        //Null gelebilecek olan CategoryID ve SupplierID de hata almamak için
        public static void SetSelectedValue(this ComboBox combo,object value)
        {
            if (value != null)
                combo.SelectedValue = value;
        }


    }
}
