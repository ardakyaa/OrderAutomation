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
        IOrderDetailBusiness orderDetailBusiness;
        public OrderForm()
        {
            InitializeComponent();

            customerBusiness = new CustomerBusiness();
            productBusiness = new ProductBusiness();
            employeeBusiness = new EmployeeBusiness();
            shipperBusiness = new ShipperBusiness();
            orderBusiness = new OrderBusiness();
            orderDetailBusiness = new OrderDetailBusiness();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            FillColumnMapping();
            FillControl();
            FillDataOrder();
                      
        }
        Order selectedOrder = null;

        private void FillDataOrder()
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
                    dtOrderDate.Value = Convert.ToDateTime(selectedOrder.OrderDate);
                    dtRequiredDate.Value = Convert.ToDateTime(selectedOrder.RequiredDate);
                    dtShippedDate.Value = Convert.ToDateTime(selectedOrder.ShippedDate);
                    nuFreight.Value =Convert.ToDecimal(selectedOrder.Freight);

                }
                FillGridOrderDetail(id);
            }
        }

        
        //Sipariş detayını doldurmak için kullanılacaktır.
        private void FillGridOrderDetail(int id)
        {
            if (id > 0)
            {
                var orderDetails = orderDetailBusiness.GetOrderDetailVMs(id);
                grid.DataSource = null;
                grid.DataSource = orderDetails;
            }
        }

        private void FillColumnMapping()
        {
            grid.AutoGenerateColumns = false;
            grid.Columns.Add(UICoreUtility.generateDataGridViewTextBoxColumn("ProductName", "ProductName", "Ürün Adı"));
            grid.Columns.Add(UICoreUtility.generateDataGridViewTextBoxColumn("UnitPrice", "UnitPrice", "Birim Fiyat"));
            grid.Columns.Add(UICoreUtility.generateDataGridViewTextBoxColumn("Quantity", "Quantity", "Miktar"));
            grid.Columns.Add(UICoreUtility.generateDataGridViewTextBoxColumn("Discount", "Discount", "İndirim"));
            grid.Columns.Add(UICoreUtility.generateDataGridViewTextBoxColumn("Total", "Total", "Satır Toplam"));
            grid.Columns["Total"].DefaultCellStyle.Format = "N2"; //Currency ayarlaması
            grid.Columns["UnitPrice"].DefaultCellStyle.Format = "N2";
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormClear();
        }

        private void FormClear()
        {
            UICoreUtility.FormClear(this);
            this.Tag = 0;
            this.selectedOrderDetail = null;
            this.selectedOrder = null;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FormSave();
        }

        //Kontrol validasyonlarını yaz!!!!
        private void FormSave()
        {
            try
            {
                if (this.selectedOrder == null)
                {
                    selectedOrder = new Order();
                }

                selectedOrder.ShipName = txtShipName.Text;
                selectedOrder.ShipAddress = txtShipName.Text;
                selectedOrder.ShipCity = txtShipCity.Text;
                selectedOrder.ShipCountry = txtShipCountry.Text;
                selectedOrder.ShipRegion = txtShipRegion.Text;
                selectedOrder.ShipPostalCode = txtShipRegion.Text;
                selectedOrder.CustomerID = cmbCustomer.SelectedValue?.ToString();
                selectedOrder.EmployeeID = cmbEmployee.GetValue<int, EmployeeVM>().Value;
                selectedOrder.ShipVia = cmbShipVia.GetValue<int, Shipper>().Value;
                selectedOrder.ShippedDate = dtShippedDate.Value;
                selectedOrder.OrderDate = dtOrderDate.Value;
                selectedOrder.RequiredDate = dtRequiredDate.Value;
                selectedOrder.Freight = nuFreight.Value;

                int id = Convert.ToInt32(this.Tag);
                if (id == 0)
                {
                    orderBusiness.Add(this.selectedOrder);
                    this.Tag = selectedOrder.OrderID;
                }
                else
                {
                    orderBusiness.Update(this.selectedOrder);
                }

                UICoreUtility.SuccessMessage("İşlem başarılı bir şekilde gerçekleşti.");

            }
            catch (Exception ex)
            {
                UICoreUtility.ErrorMessage(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FormDelete();
        }

        private void FormDelete()
        {
            try
            {
                int id = Convert.ToInt32(this.Tag);
                if (id>0)
                {
                    var dialog = UICoreUtility.DialogMessage("Kaydı silmek istediğinizden emin misiniz?");
                    if (dialog==DialogResult.OK)
                    {
                        orderDetailBusiness.Delete(id);
                        orderBusiness.Delete(id);
                        this.Close();
                    }

                }
            }

            catch (Exception ex)
            {
                UICoreUtility.ErrorMessage(ex.Message);
            }
        }

        //Order Detail Add
        Order_Detail selectedOrderDetail;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isAdded = false;
            try
            {
                if (this.selectedOrder == null)
                {
                    UICoreUtility.ErrorMessage("Lütfen önce sipariş kaydı yapınız. Sonrasında detay satırları girişini yapınız.");
                    return;
                }

                if (cmbProduct.SelectedValue == null)
                {
                    UICoreUtility.ErrorMessage("Lütfen bir ürün seçiniz.");
                    cmbProduct.Focus();
                }

                if (nuUnitPrice.Value == 0)
                {
                    UICoreUtility.ErrorMessage("Lütfen birim fiyat girişi yapınız");
                    nuUnitPrice.Focus();
                }

                if (nuQuantity.Value == 0)
                {
                    UICoreUtility.ErrorMessage("Lütfen miktar girişi yapınız");
                    nuQuantity.Focus();
                }

                if (selectedOrderDetail == null)
                {
                    selectedOrderDetail = new Order_Detail();
                    isAdded = true;
                }

                selectedOrderDetail.OrderID = selectedOrder.OrderID;
                if (isAdded)
                    selectedOrderDetail.ProductID = cmbProduct.GetValue<int, Product>().Value;
                selectedOrderDetail.UnitPrice = nuUnitPrice.Value;
                selectedOrderDetail.Quantity = Convert.ToInt16(nuQuantity.Value);
                selectedOrderDetail.Discount = Convert.ToSingle(nuDiscount.Value);

                if (isAdded)
                {
                    orderDetailBusiness.Add(selectedOrderDetail);
                }
                else
                {
                    orderDetailBusiness.Update(selectedOrderDetail);
                }
                FormOrderDetailClear();
                FillGridOrderDetail(selectedOrder.OrderID);
                UICoreUtility.SuccessMessage("İşlem başarılı bir şekilde gerçekleşti.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var orderDetailItem = (grid.DataSource as List<OrderDetailVM>)[e.RowIndex];
            if (orderDetailItem!=null)
            {
                //selectedOrderDetail = orderDetailItem;
                cmbProduct.SelectedValue = orderDetailItem.ProductId;
                nuUnitPrice.Value = orderDetailItem.UnitPrice;
                nuQuantity.Value = orderDetailItem.Quantity;
                nuDiscount.Value =Convert.ToDecimal(orderDetailItem.Discount);
                selectedOrderDetail = new Order_Detail()
                {
                    OrderID=orderDetailItem.OrderId,
                    Discount=orderDetailItem.Discount,
                    ProductID=orderDetailItem.ProductId,
                    Quantity=orderDetailItem.Quantity,
                    UnitPrice=orderDetailItem.UnitPrice
                };
            }
        }

        private void FormOrderDetailClear()
        {
            selectedOrderDetail = null;
            UICoreUtility.FormClear(pnlOrderDetail);
        }

        private void btnDeleteOrderDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (grid.SelectedRows.Count > 0)
                {
                    var dialogResult = UICoreUtility.DialogMessage("Seçilen kayıtları silmek istiyor musunuz?");
                    if (dialogResult == DialogResult.OK)
                    {
                        foreach (DataGridViewRow row in grid.SelectedRows)
                        {
                            var item = (row.DataBoundItem as OrderDetailVM);
                            orderDetailBusiness.Delete(item.OrderId, item.ProductId);
                        }
                        UICoreUtility.SuccessMessage("İşlem başarılı bir şekilde gerçekleşti");
                        FillGridOrderDetail(this.selectedOrder.OrderID);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void TotalUpdate()
        {
            var orderDetails = (grid.DataSource as List<OrderDetailVM>);
            if (orderDetails != null)
                lblToplam.Text =$"Toplam Tutar={orderDetails.Sum(t0 => t0.Total).ToString("N2")} TL" ;
        }

        private void grid_DataSourceChanged(object sender, EventArgs e)
        {
            TotalUpdate();
        }
    }
}
