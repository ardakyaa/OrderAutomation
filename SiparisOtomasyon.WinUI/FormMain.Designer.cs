
namespace SiparisOtomasyon.WinUI
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.müşteriListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCustomerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProductMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newOrderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tanımlamalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finansalAyarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriListesiToolStripMenuItem,
            this.ürünİşlemleriToolStripMenuItem,
            this.siparişİşlemleriToolStripMenuItem,
            this.tanımlamalarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(907, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müşteriListesiToolStripMenuItem
            // 
            this.müşteriListesiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCustomerMenuItem,
            this.customerListMenuItem});
            this.müşteriListesiToolStripMenuItem.Name = "müşteriListesiToolStripMenuItem";
            this.müşteriListesiToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.müşteriListesiToolStripMenuItem.Text = "Müşteri İşlemleri";
            // 
            // newCustomerMenuItem
            // 
            this.newCustomerMenuItem.Name = "newCustomerMenuItem";
            this.newCustomerMenuItem.Size = new System.Drawing.Size(149, 22);
            this.newCustomerMenuItem.Text = "Yeni Müşteri";
            this.newCustomerMenuItem.Click += new System.EventHandler(this.newCustomerMenuItem_Click);
            // 
            // customerListMenuItem
            // 
            this.customerListMenuItem.Name = "customerListMenuItem";
            this.customerListMenuItem.Size = new System.Drawing.Size(149, 22);
            this.customerListMenuItem.Text = "Müşteri Listesi";
            this.customerListMenuItem.Click += new System.EventHandler(this.customerListMenuItem_Click);
            // 
            // ürünİşlemleriToolStripMenuItem
            // 
            this.ürünİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProductMenuItem,
            this.productListMenuItem});
            this.ürünİşlemleriToolStripMenuItem.Name = "ürünİşlemleriToolStripMenuItem";
            this.ürünİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.ürünİşlemleriToolStripMenuItem.Text = "Ürün İşlemleri";
            // 
            // newProductMenuItem
            // 
            this.newProductMenuItem.Name = "newProductMenuItem";
            this.newProductMenuItem.Size = new System.Drawing.Size(135, 22);
            this.newProductMenuItem.Text = "Yeni Ürün";
            this.newProductMenuItem.Click += new System.EventHandler(this.newProductMenuItem_Click);
            // 
            // productListMenuItem
            // 
            this.productListMenuItem.Name = "productListMenuItem";
            this.productListMenuItem.Size = new System.Drawing.Size(135, 22);
            this.productListMenuItem.Text = "Ürün Listesi";
            this.productListMenuItem.Click += new System.EventHandler(this.productListMenuItem_Click);
            // 
            // siparişİşlemleriToolStripMenuItem
            // 
            this.siparişİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newOrderMenuItem,
            this.orderListMenuItem});
            this.siparişİşlemleriToolStripMenuItem.Name = "siparişİşlemleriToolStripMenuItem";
            this.siparişİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.siparişİşlemleriToolStripMenuItem.Text = "Sipariş İşlemleri";
            // 
            // newOrderMenuItem
            // 
            this.newOrderMenuItem.Name = "newOrderMenuItem";
            this.newOrderMenuItem.Size = new System.Drawing.Size(143, 22);
            this.newOrderMenuItem.Text = "Yeni Sipariş";
            this.newOrderMenuItem.Click += new System.EventHandler(this.newOrderMenuItem_Click);
            // 
            // orderListMenuItem
            // 
            this.orderListMenuItem.Name = "orderListMenuItem";
            this.orderListMenuItem.Size = new System.Drawing.Size(143, 22);
            this.orderListMenuItem.Text = "Sipariş Listesi";
            this.orderListMenuItem.Click += new System.EventHandler(this.orderListMenuItem_Click);
            // 
            // tanımlamalarToolStripMenuItem
            // 
            this.tanımlamalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.finansalAyarlarToolStripMenuItem});
            this.tanımlamalarToolStripMenuItem.Name = "tanımlamalarToolStripMenuItem";
            this.tanımlamalarToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.tanımlamalarToolStripMenuItem.Text = "Tanımlamalar";
            // 
            // finansalAyarlarToolStripMenuItem
            // 
            this.finansalAyarlarToolStripMenuItem.Name = "finansalAyarlarToolStripMenuItem";
            this.finansalAyarlarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.finansalAyarlarToolStripMenuItem.Text = "Finansal Ayarlar";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 676);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siparis Otomasyon";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müşteriListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCustomerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerListMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tanımlamalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProductMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productListMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newOrderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderListMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finansalAyarlarToolStripMenuItem;
    }
}

