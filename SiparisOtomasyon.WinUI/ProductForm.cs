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
    using DAL.Context;
    using BL.Abstract;
    using BL.Concrete;
    using Helper;

    public partial class ProductForm : Form
    {
        ICategoryBusiness categoryBusiness;
        ISupplierBusiness supplierBusiness;
        IProductBusiness productBusiness;
        public ProductForm()
        {
            InitializeComponent();
            categoryBusiness = new CategoryBusiness();
            supplierBusiness = new SupplierBusiness();
            productBusiness = new ProductBusiness();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            FillControl();
            FillData();
        }

        private void FillControl()
        {
            FillCategories();
            FillSuppliers();
        }

        private void FillCategories()
        {
            var datasource = categoryBusiness.Get();
            cmbCategories.SetDataSourceFirstItems<int, Category>(datasource, "CategoryName", "CategoryID", "Seçiniz");
        }

        private void FillSuppliers()
        {
            var datasource = supplierBusiness.Get();
            cmbSuppliers.SetDataSourceFirstItems<int, Supplier>(datasource, "CompanyName", "SupplierID", "Seçiniz");         
        }

        Product selectedProduct = null;
        private void FillData()
        {
            int id = Convert.ToInt32(this.Tag);
            if (id>0)
            {
                this.selectedProduct = productBusiness.GetById(id);
                if (this.selectedProduct!=null)
                {
                    txtProductName.Text = this.selectedProduct.ProductName;
                    cmbCategories.SetSelectedValue(selectedProduct.CategoryID);
                    cmbSuppliers.SetSelectedValue(selectedProduct.SupplierID);
                    txtQuantityPerUnit.Text = this.selectedProduct.QuantityPerUnit;
                    nuUnitPrice.Value = Convert.ToDecimal(this.selectedProduct.UnitPrice);
                    nuUnitsInStock.Value = Convert.ToDecimal(this.selectedProduct.UnitsInStock);
                    nuUnitsOnOrder.Value = Convert.ToDecimal(this.selectedProduct.UnitsOnOrder);
                    nuReorderLevel.Value = Convert.ToDecimal(this.selectedProduct.ReorderLevel);
                    cbDiscontinued.Checked = this.selectedProduct.Discontinued;

                }
            }
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            FormClear();
        }

        private void FormClear()
        {
            this.Tag = null;
            this.selectedProduct = null;

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
                if (this.selectedProduct==null)
                {
                    this.selectedProduct = new Product();
                }

                this.selectedProduct.ProductName = txtProductName.Text;
                this.selectedProduct.CategoryID = Convert.ToInt32(cmbCategories.SelectedValue);
                this.selectedProduct.SupplierID = Convert.ToInt32(cmbSuppliers.SelectedValue);
                this.selectedProduct.QuantityPerUnit = txtQuantityPerUnit.Text;
                this.selectedProduct.UnitPrice = Convert.ToDecimal(nuUnitPrice.Value);
                this.selectedProduct.UnitsInStock = Convert.ToInt16(nuUnitsInStock.Value);
                this.selectedProduct.UnitsOnOrder = Convert.ToInt16(nuUnitsOnOrder.Value);
                this.selectedProduct.ReorderLevel = Convert.ToInt16(nuReorderLevel.Value);
                this.selectedProduct.Discontinued = cbDiscontinued.Checked;

                int id = Convert.ToInt32(this.Tag);
                if (id==0)
                {
                    productBusiness.Add(this.selectedProduct);
                }
                else
                {
                    productBusiness.Update(this.selectedProduct);
                }

                UICoreUtility.SuccessMessage("İşlem başarılı bir şekilde yapıldı");

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
                if (UICoreUtility.DialogMessage("Bu kaydı silmek istiyor musunuz?") == DialogResult.OK)
                {
                    if (productBusiness.Delete(this.selectedProduct.ProductID))
                    {
                        UICoreUtility.SuccessMessage("Silme işlemi başarılı");
                    }
                    else
                    {
                        UICoreUtility.ErrorMessage("Silme işlemi sırasında hata meydana geldi");
                    }
                }
            }
            catch (Exception ex)
            {
                UICoreUtility.ErrorMessage(ex.Message);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
