
namespace Csharp_Entity_Store_Management
{
    partial class frmOrderDetail
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
            this.lbOrderID = new System.Windows.Forms.Label();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.lbCustomerAddress = new System.Windows.Forms.Label();
            this.lbCustomerPhone = new System.Windows.Forms.Label();
            this.lbUserID = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.dgvListProduct = new System.Windows.Forms.DataGridView();
            this.lbTotalMoney = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProduct)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(588, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(80, 10, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi tiết hóa đơn";
            // 
            // lbOrderID
            // 
            this.lbOrderID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderID.Location = new System.Drawing.Point(1080, 56);
            this.lbOrderID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(127, 25);
            this.lbOrderID.TabIndex = 1;
            this.lbOrderID.Text = "Mã hóa đơn: ";
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbCustomerName.Location = new System.Drawing.Point(120, 156);
            this.lbCustomerName.Margin = new System.Windows.Forms.Padding(120, 0, 4, 0);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(165, 25);
            this.lbCustomerName.TabIndex = 2;
            this.lbCustomerName.Text = "Tên khách hàng: ";
            // 
            // lbCustomerAddress
            // 
            this.lbCustomerAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCustomerAddress.AutoSize = true;
            this.lbCustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomerAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbCustomerAddress.Location = new System.Drawing.Point(120, 220);
            this.lbCustomerAddress.Margin = new System.Windows.Forms.Padding(120, 0, 4, 0);
            this.lbCustomerAddress.Name = "lbCustomerAddress";
            this.lbCustomerAddress.Size = new System.Drawing.Size(82, 25);
            this.lbCustomerAddress.TabIndex = 3;
            this.lbCustomerAddress.Text = "Địa chỉ: ";
            // 
            // lbCustomerPhone
            // 
            this.lbCustomerPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCustomerPhone.AutoSize = true;
            this.lbCustomerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomerPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbCustomerPhone.Location = new System.Drawing.Point(120, 285);
            this.lbCustomerPhone.Margin = new System.Windows.Forms.Padding(120, 0, 4, 0);
            this.lbCustomerPhone.Name = "lbCustomerPhone";
            this.lbCustomerPhone.Size = new System.Drawing.Size(137, 25);
            this.lbCustomerPhone.TabIndex = 4;
            this.lbCustomerPhone.Text = "Số điện thoại: ";
            // 
            // lbUserID
            // 
            this.lbUserID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbUserID.AutoSize = true;
            this.lbUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbUserID.Location = new System.Drawing.Point(628, 156);
            this.lbUserID.Margin = new System.Windows.Forms.Padding(120, 0, 4, 0);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(141, 25);
            this.lbUserID.TabIndex = 5;
            this.lbUserID.Text = "Mã nhân viên: ";
            // 
            // lbUsername
            // 
            this.lbUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbUsername.Location = new System.Drawing.Point(628, 220);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(120, 0, 4, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(148, 25);
            this.lbUsername.TabIndex = 6;
            this.lbUsername.Text = "Tên nhân viên: ";
            // 
            // dgvListProduct
            // 
            this.dgvListProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvListProduct, 3);
            this.dgvListProduct.Location = new System.Drawing.Point(4, 335);
            this.dgvListProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvListProduct.Name = "dgvListProduct";
            this.dgvListProduct.RowHeadersVisible = false;
            this.dgvListProduct.RowHeadersWidth = 51;
            this.dgvListProduct.Size = new System.Drawing.Size(1264, 246);
            this.dgvListProduct.TabIndex = 7;
            // 
            // lbTotalMoney
            // 
            this.lbTotalMoney.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTotalMoney.AutoSize = true;
            this.lbTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbTotalMoney.Location = new System.Drawing.Point(1020, 601);
            this.lbTotalMoney.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotalMoney.Name = "lbTotalMoney";
            this.lbTotalMoney.Size = new System.Drawing.Size(138, 29);
            this.lbTotalMoney.TabIndex = 8;
            this.lbTotalMoney.Text = "Tổng tiền: ";
            // 
            // lbDate
            // 
            this.lbDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbDate.Location = new System.Drawing.Point(200, 56);
            this.lbDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(107, 25);
            this.lbDate.TabIndex = 9;
            this.lbDate.Text = "Ngày bán: ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lbTotalMoney, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbOrderID, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbDate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvListProduct, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbCustomerPhone, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbCustomerAddress, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbCustomerName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbUserID, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbUsername, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnPrint, 2, 2);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.44703F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.644717F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.26696F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.955837F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.82335F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.86211F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1272, 645);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrint.AutoSize = true;
            this.btnPrint.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::Csharp_Entity_Store_Management.Properties.Resources.printer;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(1073, 208);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(142, 50);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "In hóa đơn";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1296, 669);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmOrderDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết hoá đơn";
            this.Load += new System.EventHandler(this.frmOrderDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProduct)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.Label lbCustomerAddress;
        private System.Windows.Forms.Label lbCustomerPhone;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.DataGridView dgvListProduct;
        private System.Windows.Forms.Label lbTotalMoney;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPrint;
    }
}