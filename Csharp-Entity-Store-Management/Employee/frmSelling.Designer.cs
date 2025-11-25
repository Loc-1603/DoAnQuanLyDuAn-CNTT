
namespace Csharp_Entity_Store_Management
{
    partial class frmSelling
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.cbbCategories = new System.Windows.Forms.ComboBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvCarts = new System.Windows.Forms.DataGridView();
            this.lblNotiCart = new System.Windows.Forms.Label();
            this.grbProductDetail = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnApplyDiscount = new System.Windows.Forms.Button();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblDetailName = new System.Windows.Forms.Label();
            this.lblDetailTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDetailPrice = new System.Windows.Forms.Label();
            this.btnIncrement = new System.Windows.Forms.Button();
            this.txtQuantityDetail = new System.Windows.Forms.TextBox();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnDecrement = new System.Windows.Forms.Button();
            this.lblDetailID = new System.Windows.Forms.Label();
            this.grbCheckCustomer = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCheckPhone = new System.Windows.Forms.Button();
            this.txtCheckPhone = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.grbAddCustomer = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btlLogout = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarts)).BeginInit();
            this.grbProductDetail.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.grbCheckCustomer.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.grbAddCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.tableLayoutPanel4);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(940, 325);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label10, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtKeyword, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.cbbCategories, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.dgvProducts, 0, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(15, 29);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(916, 290);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(461, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Danh mục:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Tìm kiếm:";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(3, 32);
            this.txtKeyword.Multiline = true;
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(238, 30);
            this.txtKeyword.TabIndex = 1;
            this.txtKeyword.TextChanged += new System.EventHandler(this.txtKeyword_TextChanged);
            // 
            // cbbCategories
            // 
            this.cbbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategories.FormattingEnabled = true;
            this.cbbCategories.Location = new System.Drawing.Point(461, 32);
            this.cbbCategories.Name = "cbbCategories";
            this.cbbCategories.Size = new System.Drawing.Size(221, 28);
            this.cbbCategories.TabIndex = 2;
            this.cbbCategories.SelectedIndexChanged += new System.EventHandler(this.cbbCategories_SelectedIndexChanged);
            // 
            // dgvProducts
            // 
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel4.SetColumnSpan(this.dgvProducts, 2);
            this.dgvProducts.Location = new System.Drawing.Point(3, 75);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(910, 212);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectedProduct);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Controls.Add(this.lblNotiCart);
            this.groupBox2.Location = new System.Drawing.Point(3, 334);
            this.groupBox2.Name = "groupBox2";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox2, 2);
            this.groupBox2.Size = new System.Drawing.Size(940, 356);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giỏ hàng";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.dgvCarts, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 29);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(922, 321);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // dgvCarts
            // 
            this.dgvCarts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCarts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel3.SetColumnSpan(this.dgvCarts, 2);
            this.dgvCarts.Location = new System.Drawing.Point(3, 3);
            this.dgvCarts.Name = "dgvCarts";
            this.dgvCarts.ReadOnly = true;
            this.dgvCarts.RowHeadersWidth = 51;
            this.tableLayoutPanel3.SetRowSpan(this.dgvCarts, 2);
            this.dgvCarts.RowTemplate.Height = 24;
            this.dgvCarts.Size = new System.Drawing.Size(916, 315);
            this.dgvCarts.TabIndex = 0;
            this.dgvCarts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewDetailProduct);
            // 
            // lblNotiCart
            // 
            this.lblNotiCart.AutoSize = true;
            this.lblNotiCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotiCart.Location = new System.Drawing.Point(6, 38);
            this.lblNotiCart.Name = "lblNotiCart";
            this.lblNotiCart.Size = new System.Drawing.Size(238, 29);
            this.lblNotiCart.TabIndex = 1;
            this.lblNotiCart.Text = "GIỎ HÀNG TRỐNG";
            // 
            // grbProductDetail
            // 
            this.grbProductDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbProductDetail.Controls.Add(this.tableLayoutPanel6);
            this.grbProductDetail.Controls.Add(this.lblDetailID);
            this.grbProductDetail.Location = new System.Drawing.Point(949, 334);
            this.grbProductDetail.Name = "grbProductDetail";
            this.grbProductDetail.Size = new System.Drawing.Size(400, 201);
            this.grbProductDetail.TabIndex = 0;
            this.grbProductDetail.TabStop = false;
            this.grbProductDetail.Text = "Chi tiết sản phẩm";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tableLayoutPanel6.Controls.Add(this.btnApplyDiscount, 3, 4);
            this.tableLayoutPanel6.Controls.Add(this.txtDiscount, 1, 4);
            this.tableLayoutPanel6.Controls.Add(this.label17, 2, 4);
            this.tableLayoutPanel6.Controls.Add(this.lblDetailName, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.lblDetailTotal, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.lblDetailPrice, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.btnIncrement, 2, 3);
            this.tableLayoutPanel6.Controls.Add(this.txtQuantityDetail, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.btnDeleteProduct, 3, 3);
            this.tableLayoutPanel6.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label16, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.btnDecrement, 0, 3);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(4, 32);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 5;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.81188F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.81188F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.81188F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.78218F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.78218F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(394, 163);
            this.tableLayoutPanel6.TabIndex = 10;
            // 
            // btnApplyDiscount
            // 
            this.btnApplyDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApplyDiscount.BackColor = System.Drawing.Color.MediumPurple;
            this.btnApplyDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyDiscount.ForeColor = System.Drawing.Color.White;
            this.btnApplyDiscount.Location = new System.Drawing.Point(226, 128);
            this.btnApplyDiscount.Name = "btnApplyDiscount";
            this.btnApplyDiscount.Size = new System.Drawing.Size(135, 32);
            this.btnApplyDiscount.TabIndex = 7;
            this.btnApplyDiscount.Text = "Sử dụng";
            this.btnApplyDiscount.UseVisualStyleBackColor = false;
            this.btnApplyDiscount.Click += new System.EventHandler(this.btnApplyDiscount_Click);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiscount.Location = new System.Drawing.Point(89, 128);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(72, 26);
            this.txtDiscount.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(167, 134);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 20);
            this.label17.TabIndex = 9;
            this.label17.Text = "%";
            // 
            // lblDetailName
            // 
            this.lblDetailName.AutoSize = true;
            this.tableLayoutPanel6.SetColumnSpan(this.lblDetailName, 3);
            this.lblDetailName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailName.Location = new System.Drawing.Point(89, 0);
            this.lblDetailName.Name = "lblDetailName";
            this.lblDetailName.Size = new System.Drawing.Size(95, 20);
            this.lblDetailName.TabIndex = 4;
            this.lblDetailName.Text = "Bánh Cosy";
            // 
            // lblDetailTotal
            // 
            this.lblDetailTotal.AutoSize = true;
            this.tableLayoutPanel6.SetColumnSpan(this.lblDetailTotal, 3);
            this.lblDetailTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailTotal.Location = new System.Drawing.Point(89, 30);
            this.lblDetailTotal.Name = "lblDetailTotal";
            this.lblDetailTotal.Size = new System.Drawing.Size(39, 20);
            this.lblDetailTotal.TabIndex = 4;
            this.lblDetailTotal.Text = "100";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Đơn giá:";
            // 
            // lblDetailPrice
            // 
            this.lblDetailPrice.AutoSize = true;
            this.tableLayoutPanel6.SetColumnSpan(this.lblDetailPrice, 3);
            this.lblDetailPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailPrice.Location = new System.Drawing.Point(89, 60);
            this.lblDetailPrice.Name = "lblDetailPrice";
            this.lblDetailPrice.Size = new System.Drawing.Size(79, 20);
            this.lblDetailPrice.TabIndex = 4;
            this.lblDetailPrice.Text = "1000000";
            // 
            // btnIncrement
            // 
            this.btnIncrement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIncrement.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnIncrement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncrement.ForeColor = System.Drawing.Color.White;
            this.btnIncrement.Location = new System.Drawing.Point(167, 93);
            this.btnIncrement.Name = "btnIncrement";
            this.btnIncrement.Size = new System.Drawing.Size(40, 29);
            this.btnIncrement.TabIndex = 1;
            this.btnIncrement.Text = "+";
            this.btnIncrement.UseVisualStyleBackColor = false;
            this.btnIncrement.Click += new System.EventHandler(this.btnIncrement_Click);
            // 
            // txtQuantityDetail
            // 
            this.txtQuantityDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantityDetail.Location = new System.Drawing.Point(89, 93);
            this.txtQuantityDetail.Name = "txtQuantityDetail";
            this.txtQuantityDetail.Size = new System.Drawing.Size(72, 26);
            this.txtQuantityDetail.TabIndex = 2;
            this.txtQuantityDetail.TextChanged += new System.EventHandler(this.txtQuantityDetail_TextChanged);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteProduct.BackColor = System.Drawing.Color.Red;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProduct.Location = new System.Drawing.Point(226, 93);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(135, 29);
            this.btnDeleteProduct.TabIndex = 3;
            this.btnDeleteProduct.Text = "Xoá";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Còn:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên:";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 134);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 20);
            this.label16.TabIndex = 8;
            this.label16.Text = "Giảm giá:";
            // 
            // btnDecrement
            // 
            this.btnDecrement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecrement.BackColor = System.Drawing.Color.Red;
            this.btnDecrement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrement.ForeColor = System.Drawing.Color.White;
            this.btnDecrement.Location = new System.Drawing.Point(43, 93);
            this.btnDecrement.Name = "btnDecrement";
            this.btnDecrement.Size = new System.Drawing.Size(40, 29);
            this.btnDecrement.TabIndex = 1;
            this.btnDecrement.Text = "-";
            this.btnDecrement.UseVisualStyleBackColor = false;
            this.btnDecrement.Click += new System.EventHandler(this.btnDecrement_Click);
            // 
            // lblDetailID
            // 
            this.lblDetailID.AutoSize = true;
            this.lblDetailID.Location = new System.Drawing.Point(2, 155);
            this.lblDetailID.Name = "lblDetailID";
            this.lblDetailID.Size = new System.Drawing.Size(0, 20);
            this.lblDetailID.TabIndex = 5;
            // 
            // grbCheckCustomer
            // 
            this.grbCheckCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbCheckCustomer.Controls.Add(this.tableLayoutPanel2);
            this.grbCheckCustomer.Location = new System.Drawing.Point(949, 3);
            this.grbCheckCustomer.Name = "grbCheckCustomer";
            this.grbCheckCustomer.Size = new System.Drawing.Size(400, 97);
            this.grbCheckCustomer.TabIndex = 0;
            this.grbCheckCustomer.TabStop = false;
            this.grbCheckCustomer.Text = "SĐT khách hàng";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.66667F));
            this.tableLayoutPanel2.Controls.Add(this.btnCheckPhone, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtCheckPhone, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(11, 26);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(372, 65);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // btnCheckPhone
            // 
            this.btnCheckPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckPhone.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCheckPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckPhone.ForeColor = System.Drawing.Color.White;
            this.btnCheckPhone.Location = new System.Drawing.Point(247, 3);
            this.btnCheckPhone.Name = "btnCheckPhone";
            this.btnCheckPhone.Size = new System.Drawing.Size(122, 39);
            this.btnCheckPhone.TabIndex = 1;
            this.btnCheckPhone.Text = "Kiểm Tra";
            this.btnCheckPhone.UseVisualStyleBackColor = false;
            this.btnCheckPhone.Click += new System.EventHandler(this.btnCheckPhone_Click);
            // 
            // txtCheckPhone
            // 
            this.txtCheckPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCheckPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckPhone.Location = new System.Drawing.Point(3, 3);
            this.txtCheckPhone.Multiline = true;
            this.txtCheckPhone.Name = "txtCheckPhone";
            this.txtCheckPhone.Size = new System.Drawing.Size(229, 39);
            this.txtCheckPhone.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(12, 9);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(153, 20);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "Xin chào: Nhân Viên";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.grbCheckCustomer, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.grbProductDetail, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.grbAddCustomer, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 37);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1352, 693);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.tableLayoutPanel5);
            this.groupBox3.Location = new System.Drawing.Point(949, 541);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 149);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnPay, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblTotalAmount, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(6, 18);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(388, 122);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thành tiền:";
            // 
            // btnPay
            // 
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPay.BackColor = System.Drawing.Color.RoyalBlue;
            this.tableLayoutPanel5.SetColumnSpan(this.btnPay, 2);
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(3, 51);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(382, 68);
            this.btnPay.TabIndex = 1;
            this.btnPay.Text = "Thanh Toán";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(119, 28);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(61, 20);
            this.lblTotalAmount.TabIndex = 3;
            this.lblTotalAmount.Text = "0 VNĐ";
            // 
            // grbAddCustomer
            // 
            this.grbAddCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbAddCustomer.Controls.Add(this.btnUpdate);
            this.grbAddCustomer.Controls.Add(this.btnAddCustomer);
            this.grbAddCustomer.Controls.Add(this.txtCustomerPhone);
            this.grbAddCustomer.Controls.Add(this.txtCustomerAddress);
            this.grbAddCustomer.Controls.Add(this.txtCustomerName);
            this.grbAddCustomer.Controls.Add(this.label4);
            this.grbAddCustomer.Controls.Add(this.label3);
            this.grbAddCustomer.Controls.Add(this.label2);
            this.grbAddCustomer.Location = new System.Drawing.Point(949, 106);
            this.grbAddCustomer.Name = "grbAddCustomer";
            this.grbAddCustomer.Size = new System.Drawing.Size(400, 222);
            this.grbAddCustomer.TabIndex = 4;
            this.grbAddCustomer.TabStop = false;
            this.grbAddCustomer.Text = "Thông tin khách hàng";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.OrangeRed;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(176, 153);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 42);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.Location = new System.Drawing.Point(176, 153);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(94, 42);
            this.btnAddCustomer.TabIndex = 6;
            this.btnAddCustomer.Text = "Thêm";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(97, 117);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(255, 26);
            this.txtCustomerPhone.TabIndex = 5;
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(97, 76);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(255, 26);
            this.txtCustomerAddress.TabIndex = 4;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(97, 35);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(255, 26);
            this.txtCustomerName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "SĐT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên:";
            // 
            // btlLogout
            // 
            this.btlLogout.AutoSize = true;
            this.btlLogout.BackColor = System.Drawing.Color.DodgerBlue;
            this.btlLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlLogout.ForeColor = System.Drawing.Color.White;
            this.btlLogout.Location = new System.Drawing.Point(210, -2);
            this.btlLogout.Name = "btlLogout";
            this.btlLogout.Size = new System.Drawing.Size(107, 36);
            this.btlLogout.TabIndex = 7;
            this.btlLogout.Text = "Đăng xuất";
            this.btlLogout.UseVisualStyleBackColor = false;
            this.btlLogout.Click += new System.EventHandler(this.btlLogout_Click);
            // 
            // frmSelling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 742);
            this.Controls.Add(this.btlLogout);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblUserName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSelling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSelling_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarts)).EndInit();
            this.grbProductDetail.ResumeLayout(false);
            this.grbProductDetail.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.grbCheckCustomer.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.grbAddCustomer.ResumeLayout(false);
            this.grbAddCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grbProductDetail;
        private System.Windows.Forms.GroupBox grbCheckCustomer;
        private System.Windows.Forms.Button btnCheckPhone;
        private System.Windows.Forms.TextBox txtCheckPhone;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.TextBox txtQuantityDetail;
        private System.Windows.Forms.Button btnIncrement;
        private System.Windows.Forms.Button btnDecrement;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbCategories;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.DataGridView dgvCarts;
        private System.Windows.Forms.Label lblDetailPrice;
        private System.Windows.Forms.Label lblDetailTotal;
        private System.Windows.Forms.Label lblDetailName;
        private System.Windows.Forms.Label lblNotiCart;
        private System.Windows.Forms.Label lblDetailID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnApplyDiscount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.GroupBox grbAddCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btlLogout;
    }
}