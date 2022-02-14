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
    using SiparisOtomasyon.WinUI.Helper;

    public partial class CustomerListForm : Form
    {
        public CustomerListForm()
        {
            InitializeComponent();

            customerBusiness = new CustomerBusiness();
        }

        ICustomerBusiness customerBusiness;

        private void CustomerListForm_Load(object sender, EventArgs e)
        {
            FillColumnMapping();
            FillGrid();
        }

        private void FillColumnMapping()
        {
            grid.AutoGenerateColumns = false;
            grid.Columns.Add(UICoreUtility.generateDataGridViewTextBoxColumn("CompanyName", "CompanyName", "Müşteri Adı"));
            grid.Columns.Add(UICoreUtility.generateDataGridViewTextBoxColumn("ContactName", "ContactName", "İlgili Kişi"));
            grid.Columns.Add(UICoreUtility.generateDataGridViewTextBoxColumn("ContactTitle", "ContactTitle", "İlgili Unvan"));
            grid.Columns.Add(UICoreUtility.generateDataGridViewTextBoxColumn("Phone", "Phone", "Telefon"));
            
        }

        private void FillGrid()
        {
            grid.DataSource = null;
            var result = customerBusiness.Get();
            grid.DataSource = result;
        }


        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var customer = (grid.DataSource as List<Customer>)[e.RowIndex];

            var form = new CustomerForm();
            form.MdiParent = this.MdiParent;
            form.Dock = DockStyle.Fill;
            form.Tag = customer.CustomerID;
            form.FormClosed += Form_FormClosed;
            form.Show();
            
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            FillGrid();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
