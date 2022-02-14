using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisOtomasyon.WinUI
{
    using BL.Abstract;
    using BL.Concrete;
    using SiparisOtomasyon.DAL.Context;
    using SiparisOtomasyon.DAL.VM;
    using SiparisOtomasyon.WinUI.Helper;

    public partial class OrderListForm : Form
    {
        IOrderBusiness orderBusiness;

        public OrderListForm()
        {
            InitializeComponent();
            orderBusiness = new OrderBusiness();
        }

        private void OrderListForm_Load(object sender, EventArgs e)
        {
            FillColumnMapping();
            FillGrid();
        }

        private void FillColumnMapping()
        {
            grid.AutoGenerateColumns = false;
            grid.Columns.Add(UICoreUtility.generateDataGridViewTextBoxColumn("OrderId", "OrderId", "Sipariş ID"));
            grid.Columns.Add(UICoreUtility.generateDataGridViewTextBoxColumn("CompanyName", "CompanyName", "Müşteri"));
            grid.Columns.Add(UICoreUtility.generateDataGridViewTextBoxColumn("EmployeeName", "EmployeeName", "İlgili Çalışan"));
            grid.Columns.Add(UICoreUtility.generateDataGridViewTextBoxColumn("OrderDate", "OrderDate", "Sipariş Tarihi"));

        }

        private void FillGrid()
        {
            grid.DataSource = null;
            var result = orderBusiness.GetOrderVMs();
            grid.DataSource = result;
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var order = (grid.DataSource as List<OrderVM>)[e.RowIndex];
            if (order != null)
            {
                var form = new OrderForm();
                form.MdiParent = this.MdiParent;
                form.Dock = DockStyle.Fill;
                form.Tag = order.OrderId;
                form.FormClosed += Form_FormClosed;
                form.Show();
            }
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            FillGrid();
        }
    }
}
