
namespace SiparisOtomasyon.WinUI
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbDiscontinued = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nuReorderLevel = new System.Windows.Forms.NumericUpDown();
            this.nuUnitsOnOrder = new System.Windows.Forms.NumericUpDown();
            this.nuUnitsInStock = new System.Windows.Forms.NumericUpDown();
            this.nuUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.cmbSuppliers = new System.Windows.Forms.ComboBox();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuReorderLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuUnitsOnOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuUnitsInStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuUnitPrice)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 95);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Formu";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.cbDiscontinued);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.nuReorderLevel);
            this.panel2.Controls.Add(this.nuUnitsOnOrder);
            this.panel2.Controls.Add(this.nuUnitsInStock);
            this.panel2.Controls.Add(this.nuUnitPrice);
            this.panel2.Controls.Add(this.cmbSuppliers);
            this.panel2.Controls.Add(this.cmbCategories);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtQuantityPerUnit);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtProductName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 95);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(849, 414);
            this.panel2.TabIndex = 1;
            // 
            // cbDiscontinued
            // 
            this.cbDiscontinued.AutoSize = true;
            this.cbDiscontinued.Location = new System.Drawing.Point(124, 228);
            this.cbDiscontinued.Name = "cbDiscontinued";
            this.cbDiscontinued.Size = new System.Drawing.Size(89, 21);
            this.cbDiscontinued.TabIndex = 7;
            this.cbDiscontinued.Text = "checkBox1";
            this.cbDiscontinued.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Satışta Mı?";
            // 
            // nuReorderLevel
            // 
            this.nuReorderLevel.Location = new System.Drawing.Point(526, 228);
            this.nuReorderLevel.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nuReorderLevel.Name = "nuReorderLevel";
            this.nuReorderLevel.Size = new System.Drawing.Size(203, 25);
            this.nuReorderLevel.TabIndex = 5;
            // 
            // nuUnitsOnOrder
            // 
            this.nuUnitsOnOrder.Enabled = false;
            this.nuUnitsOnOrder.Location = new System.Drawing.Point(526, 197);
            this.nuUnitsOnOrder.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nuUnitsOnOrder.Name = "nuUnitsOnOrder";
            this.nuUnitsOnOrder.Size = new System.Drawing.Size(203, 25);
            this.nuUnitsOnOrder.TabIndex = 5;
            // 
            // nuUnitsInStock
            // 
            this.nuUnitsInStock.Location = new System.Drawing.Point(526, 165);
            this.nuUnitsInStock.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nuUnitsInStock.Name = "nuUnitsInStock";
            this.nuUnitsInStock.Size = new System.Drawing.Size(203, 25);
            this.nuUnitsInStock.TabIndex = 5;
            // 
            // nuUnitPrice
            // 
            this.nuUnitPrice.DecimalPlaces = 2;
            this.nuUnitPrice.Location = new System.Drawing.Point(124, 197);
            this.nuUnitPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nuUnitPrice.Name = "nuUnitPrice";
            this.nuUnitPrice.Size = new System.Drawing.Size(203, 25);
            this.nuUnitPrice.TabIndex = 4;
            // 
            // cmbSuppliers
            // 
            this.cmbSuppliers.FormattingEnabled = true;
            this.cmbSuppliers.Location = new System.Drawing.Point(124, 124);
            this.cmbSuppliers.Name = "cmbSuppliers";
            this.cmbSuppliers.Size = new System.Drawing.Size(605, 25);
            this.cmbSuppliers.TabIndex = 3;
            // 
            // cmbCategories
            // 
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(124, 93);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(605, 25);
            this.cmbCategories.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(421, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Kritik Seviye";
            // 
            // txtQuantityPerUnit
            // 
            this.txtQuantityPerUnit.Location = new System.Drawing.Point(124, 165);
            this.txtQuantityPerUnit.Name = "txtQuantityPerUnit";
            this.txtQuantityPerUnit.Size = new System.Drawing.Size(203, 25);
            this.txtQuantityPerUnit.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(421, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sipariş Miktarı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(421, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Stok Miktarı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fiyat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Birim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tedarikçiler";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(124, 61);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(605, 25);
            this.txtProductName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kategoriler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Adı";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnNewProduct);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 444);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(849, 65);
            this.panel3.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(748, 15);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 35);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Kapat";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(203, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 35);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(108, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 35);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProduct.Location = new System.Drawing.Point(13, 15);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(89, 35);
            this.btnNewProduct.TabIndex = 0;
            this.btnNewProduct.Text = "Yeni";
            this.btnNewProduct.UseVisualStyleBackColor = true;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 509);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "ProductForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuReorderLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuUnitsOnOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuUnitsInStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuUnitPrice)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNewProduct;
        private System.Windows.Forms.CheckBox cbDiscontinued;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nuReorderLevel;
        private System.Windows.Forms.NumericUpDown nuUnitsOnOrder;
        private System.Windows.Forms.NumericUpDown nuUnitsInStock;
        private System.Windows.Forms.NumericUpDown nuUnitPrice;
        private System.Windows.Forms.ComboBox cmbSuppliers;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQuantityPerUnit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
    }
}