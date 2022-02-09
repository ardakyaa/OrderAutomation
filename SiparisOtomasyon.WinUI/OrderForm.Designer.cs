
namespace SiparisOtomasyon.WinUI
{
    partial class OrderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grid = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.nuDiscount = new System.Windows.Forms.NumericUpDown();
            this.nuQuantity = new System.Windows.Forms.NumericUpDown();
            this.nuUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtShipRegion = new System.Windows.Forms.TextBox();
            this.txtShipCity = new System.Windows.Forms.TextBox();
            this.txtShipPostalCode = new System.Windows.Forms.TextBox();
            this.txtShipAddress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtShipCountry = new System.Windows.Forms.TextBox();
            this.txtShipName = new System.Windows.Forms.TextBox();
            this.nuFreight = new System.Windows.Forms.NumericUpDown();
            this.dtShippedDate = new System.Windows.Forms.DateTimePicker();
            this.dtRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.dtOrderDate = new System.Windows.Forms.DateTimePicker();
            this.cmbShipVia = new System.Windows.Forms.ComboBox();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuUnitPrice)).BeginInit();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuFreight)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(5, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sipariş Form";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 75);
            this.panel1.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(814, 18);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 34);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Kapat";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnNew);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 605);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(910, 64);
            this.panel3.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(192, 17);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 34);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(102, 17);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 34);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.White;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Location = new System.Drawing.Point(12, 17);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(84, 34);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Yeni";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 381);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 224);
            this.panel2.TabIndex = 4;
            // 
            // grid
            // 
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowTemplate.Height = 24;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(910, 224);
            this.grid.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.btnDeleteOrder);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.nuDiscount);
            this.panel4.Controls.Add(this.nuQuantity);
            this.panel4.Controls.Add(this.nuUnitPrice);
            this.panel4.Controls.Add(this.cmbProduct);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 340);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(910, 41);
            this.panel4.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(9, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(63, 26);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteOrder.Location = new System.Drawing.Point(834, 6);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(63, 26);
            this.btnDeleteOrder.TabIndex = 5;
            this.btnDeleteOrder.Text = "Sil";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(82, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 17);
            this.label15.TabIndex = 1;
            this.label15.Text = "Ürün";
            // 
            // nuDiscount
            // 
            this.nuDiscount.DecimalPlaces = 2;
            this.nuDiscount.Location = new System.Drawing.Point(748, 6);
            this.nuDiscount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nuDiscount.Name = "nuDiscount";
            this.nuDiscount.Size = new System.Drawing.Size(71, 25);
            this.nuDiscount.TabIndex = 4;
            this.nuDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nuQuantity
            // 
            this.nuQuantity.DecimalPlaces = 2;
            this.nuQuantity.Location = new System.Drawing.Point(618, 7);
            this.nuQuantity.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nuQuantity.Name = "nuQuantity";
            this.nuQuantity.Size = new System.Drawing.Size(67, 25);
            this.nuQuantity.TabIndex = 4;
            this.nuQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nuUnitPrice
            // 
            this.nuUnitPrice.DecimalPlaces = 2;
            this.nuUnitPrice.Location = new System.Drawing.Point(463, 7);
            this.nuUnitPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nuUnitPrice.Name = "nuUnitPrice";
            this.nuUnitPrice.Size = new System.Drawing.Size(96, 25);
            this.nuUnitPrice.TabIndex = 4;
            this.nuUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(126, 6);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(233, 25);
            this.cmbProduct.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(691, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 17);
            this.label18.TabIndex = 1;
            this.label18.Text = "İndirim";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(565, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 17);
            this.label17.TabIndex = 1;
            this.label17.Text = "Miktar";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(385, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 17);
            this.label16.TabIndex = 1;
            this.label16.Text = "Birim Fiyat";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Controls.Add(this.nuFreight);
            this.panel5.Controls.Add(this.dtShippedDate);
            this.panel5.Controls.Add(this.dtRequiredDate);
            this.panel5.Controls.Add(this.dtOrderDate);
            this.panel5.Controls.Add(this.cmbShipVia);
            this.panel5.Controls.Add(this.cmbEmployee);
            this.panel5.Controls.Add(this.cmbCustomer);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 75);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(910, 265);
            this.panel5.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtShipRegion);
            this.groupBox1.Controls.Add(this.txtShipCity);
            this.groupBox1.Controls.Add(this.txtShipPostalCode);
            this.groupBox1.Controls.Add(this.txtShipAddress);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtShipCountry);
            this.groupBox1.Controls.Add(this.txtShipName);
            this.groupBox1.Location = new System.Drawing.Point(9, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 146);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teslim Bilgileri";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(224, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Bölge";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(461, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Şehir";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Posta Kodu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Adres";
            // 
            // txtShipRegion
            // 
            this.txtShipRegion.Location = new System.Drawing.Point(272, 58);
            this.txtShipRegion.Name = "txtShipRegion";
            this.txtShipRegion.Size = new System.Drawing.Size(146, 25);
            this.txtShipRegion.TabIndex = 0;
            // 
            // txtShipCity
            // 
            this.txtShipCity.Location = new System.Drawing.Point(519, 58);
            this.txtShipCity.Name = "txtShipCity";
            this.txtShipCity.Size = new System.Drawing.Size(156, 25);
            this.txtShipCity.TabIndex = 0;
            // 
            // txtShipPostalCode
            // 
            this.txtShipPostalCode.Location = new System.Drawing.Point(113, 58);
            this.txtShipPostalCode.Name = "txtShipPostalCode";
            this.txtShipPostalCode.Size = new System.Drawing.Size(105, 25);
            this.txtShipPostalCode.TabIndex = 0;
            // 
            // txtShipAddress
            // 
            this.txtShipAddress.Location = new System.Drawing.Point(113, 89);
            this.txtShipAddress.Multiline = true;
            this.txtShipAddress.Name = "txtShipAddress";
            this.txtShipAddress.Size = new System.Drawing.Size(562, 49);
            this.txtShipAddress.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(461, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Ülke";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Alıcı";
            // 
            // txtShipCountry
            // 
            this.txtShipCountry.Location = new System.Drawing.Point(519, 27);
            this.txtShipCountry.Name = "txtShipCountry";
            this.txtShipCountry.Size = new System.Drawing.Size(156, 25);
            this.txtShipCountry.TabIndex = 0;
            // 
            // txtShipName
            // 
            this.txtShipName.Location = new System.Drawing.Point(113, 27);
            this.txtShipName.Name = "txtShipName";
            this.txtShipName.Size = new System.Drawing.Size(305, 25);
            this.txtShipName.TabIndex = 0;
            // 
            // nuFreight
            // 
            this.nuFreight.DecimalPlaces = 2;
            this.nuFreight.Location = new System.Drawing.Point(531, 43);
            this.nuFreight.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nuFreight.Name = "nuFreight";
            this.nuFreight.Size = new System.Drawing.Size(129, 25);
            this.nuFreight.TabIndex = 4;
            this.nuFreight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtShippedDate
            // 
            this.dtShippedDate.Location = new System.Drawing.Point(757, 43);
            this.dtShippedDate.Name = "dtShippedDate";
            this.dtShippedDate.Size = new System.Drawing.Size(129, 25);
            this.dtShippedDate.TabIndex = 3;
            // 
            // dtRequiredDate
            // 
            this.dtRequiredDate.Location = new System.Drawing.Point(757, 12);
            this.dtRequiredDate.Name = "dtRequiredDate";
            this.dtRequiredDate.Size = new System.Drawing.Size(129, 25);
            this.dtRequiredDate.TabIndex = 3;
            // 
            // dtOrderDate
            // 
            this.dtOrderDate.Location = new System.Drawing.Point(531, 12);
            this.dtOrderDate.Name = "dtOrderDate";
            this.dtOrderDate.Size = new System.Drawing.Size(129, 25);
            this.dtOrderDate.TabIndex = 3;
            // 
            // cmbShipVia
            // 
            this.cmbShipVia.FormattingEnabled = true;
            this.cmbShipVia.Location = new System.Drawing.Point(109, 74);
            this.cmbShipVia.Name = "cmbShipVia";
            this.cmbShipVia.Size = new System.Drawing.Size(309, 25);
            this.cmbShipVia.TabIndex = 2;
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(109, 43);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(309, 25);
            this.cmbEmployee.TabIndex = 2;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(109, 12);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(309, 25);
            this.cmbCustomer.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(666, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Teslim Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(666, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Termin Tarihi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(437, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Taşıma Ücreti";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Kargo Firması";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sipariş Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Personel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Müşteri";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 669);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuUnitPrice)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuFreight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nuDiscount;
        private System.Windows.Forms.NumericUpDown nuQuantity;
        private System.Windows.Forms.NumericUpDown nuUnitPrice;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtShipRegion;
        private System.Windows.Forms.TextBox txtShipCity;
        private System.Windows.Forms.TextBox txtShipPostalCode;
        private System.Windows.Forms.TextBox txtShipAddress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtShipCountry;
        private System.Windows.Forms.TextBox txtShipName;
        private System.Windows.Forms.NumericUpDown nuFreight;
        private System.Windows.Forms.DateTimePicker dtShippedDate;
        private System.Windows.Forms.DateTimePicker dtRequiredDate;
        private System.Windows.Forms.DateTimePicker dtOrderDate;
        private System.Windows.Forms.ComboBox cmbShipVia;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.DataGridView grid;
    }
}