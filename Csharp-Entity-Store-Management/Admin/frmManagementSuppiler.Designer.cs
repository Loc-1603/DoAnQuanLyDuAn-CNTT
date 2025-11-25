
namespace Csharp_Entity_Store_Management
{
    partial class frmManagementSuppiler
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
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.lblTenNCC = new System.Windows.Forms.Label();
            this.lblDC = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtDCNCC = new System.Windows.Forms.TextBox();
            this.dataGridViewSupplier = new System.Windows.Forms.DataGridView();
            this.btnEditSupplier = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelSupplier = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.txtSearchKeyword = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbxAddress = new System.Windows.Forms.ComboBox();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNCC.Location = new System.Drawing.Point(4, 93);
            this.lblMaNCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.lblMaNCC.Size = new System.Drawing.Size(145, 25);
            this.lblMaNCC.TabIndex = 3;
            this.lblMaNCC.Text = "Mã NCC:";
            // 
            // lblTenNCC
            // 
            this.lblTenNCC.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTenNCC.AutoSize = true;
            this.lblTenNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNCC.Location = new System.Drawing.Point(4, 158);
            this.lblTenNCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenNCC.Name = "lblTenNCC";
            this.lblTenNCC.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.lblTenNCC.Size = new System.Drawing.Size(152, 25);
            this.lblTenNCC.TabIndex = 4;
            this.lblTenNCC.Text = "Tên NCC:";
            // 
            // lblDC
            // 
            this.lblDC.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDC.AutoSize = true;
            this.lblDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDC.Location = new System.Drawing.Point(4, 221);
            this.lblDC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDC.Name = "lblDC";
            this.lblDC.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.lblDC.Size = new System.Drawing.Size(127, 25);
            this.lblDC.TabIndex = 5;
            this.lblDC.Text = "Địa chỉ:";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMaNCC.Location = new System.Drawing.Point(324, 90);
            this.txtMaNCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(270, 30);
            this.txtMaNCC.TabIndex = 2;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTenNCC.Location = new System.Drawing.Point(324, 155);
            this.txtTenNCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(270, 30);
            this.txtTenNCC.TabIndex = 0;
            // 
            // txtDCNCC
            // 
            this.txtDCNCC.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDCNCC.Location = new System.Drawing.Point(324, 218);
            this.txtDCNCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDCNCC.Name = "txtDCNCC";
            this.txtDCNCC.Size = new System.Drawing.Size(270, 30);
            this.txtDCNCC.TabIndex = 1;
            // 
            // dataGridViewSupplier
            // 
            this.dataGridViewSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridViewSupplier, 4);
            this.dataGridViewSupplier.Location = new System.Drawing.Point(4, 328);
            this.dataGridViewSupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewSupplier.Name = "dataGridViewSupplier";
            this.dataGridViewSupplier.RowHeadersVisible = false;
            this.dataGridViewSupplier.RowHeadersWidth = 10;
            this.dataGridViewSupplier.Size = new System.Drawing.Size(1272, 355);
            this.dataGridViewSupplier.TabIndex = 11;
            this.dataGridViewSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSupplier_CellClick);
            // 
            // btnEditSupplier
            // 
            this.btnEditSupplier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEditSupplier.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSupplier.ForeColor = System.Drawing.Color.White;
            this.btnEditSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditSupplier.Location = new System.Drawing.Point(822, 211);
            this.btnEditSupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditSupplier.Name = "btnEditSupplier";
            this.btnEditSupplier.Size = new System.Drawing.Size(115, 45);
            this.btnEditSupplier.TabIndex = 8;
            this.btnEditSupplier.Text = "Cập nhật";
            this.btnEditSupplier.UseVisualStyleBackColor = false;
            this.btnEditSupplier.Click += new System.EventHandler(this.btnEditSupplier_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnClear.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(644, 148);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 45);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelSupplier
            // 
            this.btnDelSupplier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDelSupplier.BackColor = System.Drawing.Color.Red;
            this.btnDelSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelSupplier.ForeColor = System.Drawing.Color.White;
            this.btnDelSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelSupplier.Location = new System.Drawing.Point(822, 148);
            this.btnDelSupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelSupplier.Name = "btnDelSupplier";
            this.btnDelSupplier.Size = new System.Drawing.Size(115, 45);
            this.btnDelSupplier.TabIndex = 7;
            this.btnDelSupplier.Text = "Xóa";
            this.btnDelSupplier.UseVisualStyleBackColor = false;
            this.btnDelSupplier.Click += new System.EventHandler(this.btnDelSupplier_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddSupplier.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupplier.ForeColor = System.Drawing.Color.White;
            this.btnAddSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSupplier.Location = new System.Drawing.Point(644, 211);
            this.btnAddSupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(115, 45);
            this.btnAddSupplier.TabIndex = 6;
            this.btnAddSupplier.Text = "Thêm";
            this.btnAddSupplier.UseVisualStyleBackColor = false;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // txtSearchKeyword
            // 
            this.txtSearchKeyword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSearchKeyword.ForeColor = System.Drawing.Color.Silver;
            this.txtSearchKeyword.Location = new System.Drawing.Point(3, 279);
            this.txtSearchKeyword.Name = "txtSearchKeyword";
            this.txtSearchKeyword.Size = new System.Drawing.Size(250, 30);
            this.txtSearchKeyword.TabIndex = 12;
            this.txtSearchKeyword.Text = "  Nhập tên NCC";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSearch.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(323, 271);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(115, 45);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbxAddress
            // 
            this.cbxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAddress.FormattingEnabled = true;
            this.cbxAddress.Location = new System.Drawing.Point(643, 281);
            this.cbxAddress.Name = "cbxAddress";
            this.cbxAddress.Size = new System.Drawing.Size(172, 33);
            this.cbxAddress.TabIndex = 14;
            this.cbxAddress.SelectedValueChanged += new System.EventHandler(this.cbxAddress_SelectedValueChanged);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnViewAll.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.ForeColor = System.Drawing.Color.White;
            this.btnViewAll.Location = new System.Drawing.Point(821, 271);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(115, 45);
            this.btnViewAll.TabIndex = 15;
            this.btnViewAll.Text = "Xem tất cả";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.90625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.09375F));
            this.tableLayoutPanel1.Controls.Add(this.lblMaNCC, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtMaNCC, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbxAddress, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblTenNCC, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtTenNCC, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewSupplier, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtSearchKeyword, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDC, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtDCNCC, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAddSupplier, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnDelSupplier, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnEditSupplier, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnViewAll, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnImport, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnExport, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.54422F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.863946F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.183674F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.183674F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.503401F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.72109F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1280, 688);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 4);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(451, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "QUẢN LÝ NHÀ CUNG CẤP";
            // 
            // btnImport
            // 
            this.btnImport.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Location = new System.Drawing.Point(643, 83);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(115, 45);
            this.btnImport.TabIndex = 18;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnExport.BackColor = System.Drawing.Color.Crimson;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(821, 83);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(115, 45);
            this.btnExport.TabIndex = 17;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmManagementSuppiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1304, 712);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmManagementSuppiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà cung cấp";
            this.Load += new System.EventHandler(this.frmManagementSuppiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMaNCC;
        private System.Windows.Forms.Label lblTenNCC;
        private System.Windows.Forms.Label lblDC;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtDCNCC;
        private System.Windows.Forms.DataGridView dataGridViewSupplier;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Button btnEditSupplier;
        private System.Windows.Forms.Button btnDelSupplier;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSearchKeyword;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbxAddress;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
    }
}