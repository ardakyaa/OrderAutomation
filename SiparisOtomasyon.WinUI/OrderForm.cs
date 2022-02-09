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
    using DAL.Abstract;
    using DAL.Concrete;
    using DAL.Context;
    using DAL.VM;
    using SiparisOtomasyon.WinUI.Helper;

    public partial class OrderForm : Form
    {
        ICustomerBusiness customerBusiness;
        IProductBusiness productBusiness;
        IEmployeeBusiness employeeBusiness;
        IShipperBusiness shipperBusiness;
        IOrderBusiness orderBusiness;
        public OrderForm()
        {
            InitializeComponent();

            customerBusiness = new CustomerBusiness();
            productBusiness = new ProductBusiness();
            employeeBusiness = new EmployeeBusiness();
            shipperBusiness = new ShipperBusiness();
            orderBusiness = new OrderBusiness();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            FillColumnMapping();
            FillControl();
            FillData();
                      
        }
        Order selectedOrder = null;

        private void FillData()
        {
            int id = Convert.ToInt32(this.Tag);
            if (id>0)
            {
                selectedOrder = orderBusiness.GetById(id);
                if (selectedOrder!=null)
                {
                    txtShipName.Text = selectedOrder.ShipName;
                    txtShipCity.Text = selectedOrder.ShipCity;
                    txtShipCountry.Text = selectedOrder.ShipCountry;
                    txtShipAddress.Text = selectedOrder.ShipAddress;
                    txtShipPostalCode.Text = selectedOrder.ShipPostalCode;
                    txtShipRegion.Text = selectedOrder.ShipRegion;
                    cmbCustomer.SetSelectedValue(selectedOrder.CustomerID);
                    cmbEmployee.SetSelectedValue(selectedOrder.EmployeeID);
                    cmbShipVia.SetSelectedValue(selectedOrder.ShipVia);
                    dtOrderDate.Value = selectedOrder.OrderDate.Value;
                    dtRequiredDate.Value = selectedOrder.RequiredDate.Value;
                    dtShippedDate.Value = selectedOrder.ShippedDate.Value;
                    nuFreight.Value =Convert.ToDecimal(selectedOrder.Freight);

                }
                FillGridOrderDetails();
            }
        }

        private void FillGridOrderDetails()
        {
            int id = selectedOrder.OrderID;
            grid.DataSource = null;
            var result = orderBusiness.GetOrderDetailVMs(id);
            grid.DataSource = result;
        }
        private void FillColumnMapping()
        {
            grid.AutoGenerateColumns = false;
            grid.Columns.Add(UICoreUtility.generateDataGridViewTextBoxColumn("OrderId", "OrderId", "Sipariş ID"));
            grid.Columns.Add(UICoreUtility.generateDataGridViewTextBoxColumn("ProductName", "ProductName", "Ürün Adı"));
            grid.Columns.Add(UICoreUtility.generateDataGridViewTextBoxColumn("UnitPrice", "UnitPrice", "Birim Fiyat"));
            grid.Columns.Add(UICoreUtility.generateDataGridViewTextBoxColumn("Quantity", "Quantity", "Miktar"));
            grid.Columns.Add(UICoreUtility.generateDataGridViewTextBoxColumn("Discount", "Discount", "İndirim"));

        }

        private void FillControl()
        {
            FillCustomers();
            FillEmployees();
            FillShippers();
            FillProducts();
        }

        private void FillProducts()
        {
            var datasource = productBusiness.Get();
            cmbProduct.SetDataSourceFirstItems<int, Product>(datasource, "ProductName", "ProductID", "Seçiniz");
        }

        private void FillShippers()
        {
            var datasource = shipperBusiness.Get();
            cmbShipVia.SetDataSourceFirstItems<int, Shipper>(datasource, "CompanyName", "ShipperID", "Seçiniz");
        }

        private void FillEmployees()
        {
            var datasource = employeeBusiness.GetEmployeeVMs();
            cmbEmployee.SetDataSourceFirstItems<int, EmployeeVM>(datasource, "EmployeeNameAndSurname", "EmployeeId", "Seçiniz");
        }

        private void FillCustomers()
        {
            var datasource = customerBusiness.Get();
            cmbCustomer.SetCustomerFirstItems<Customer>(datasource, "CompanyName", "CustomerID", "Seçiniz");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormClear();
        }

        private void FormClear()
        {
            this.Tag = null;
            this.selectedOrder = null;

            UICoreUtility.FormClear(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FormSave();
        }

        private void FormSave()
        {
            try
            {
                if (this.selectedOrder == null)
                {
                    this.selectedOrder = new Order();
                }

                this.selectedOrder.ShipName = txtShipName.Text;
                this.selectedOrder.ShipAddress = txtShipName.Text;
                this.selectedOrder.ShipCity = txtShipCity.Text;
                this.selectedOrder.ShipCountry = txtShipCountry.Text;
                this.selectedOrder.ShipRegion = txtShipRegion.Text;
                this.selectedOrder.ShipPostalCode = txtShipRegion.Text;
                this.selectedOrder.CustomerID = cmbCustomer.SelectedValue.ToString();
                this.selectedOrder.EmployeeID = Convert.ToInt32(cmbEmployee.SelectedValue);
                this.selectedOrder.ShipVia = Convert.ToInt32(cmbShipVia.SelectedValue);
                this.selectedOrder.ShippedDate = dtShippedDate.Value;
                this.selectedOrder.OrderDate = dtOrderDate.Value;
                this.selectedOrder.RequiredDate = dtRequiredDate.Value;
                this.selectedOrder.Freight = nuFreight.Value;


                int id = Convert.ToInt32(this.Tag);
                if (id == 0)
                {
                    orderBusiness.Add(this.selectedOrder);

                }
                else
                {
                    orderBusiness.Update(this.selectedOrder);
                }



                UICoreUtility.SuccessMessage("İşlem başarılı bir şekilde yapıldı");

            }
            catch (Exception ex)
            {
                UICoreUtility.ErrorMessage(ex.Message);
            }
        }
    }
}
