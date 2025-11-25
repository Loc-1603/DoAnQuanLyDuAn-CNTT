
namespace Csharp_Entity_Store_Management
{
    partial class frmManagementOrder
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
            this.OrderManagement = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.grbOrderDetail = new System.Windows.Forms.GroupBox();
            this.lbOrderID = new System.Windows.Forms.Label();
            this.lbCusID = new System.Windows.Forms.Label();
            this.lbUserID = new System.Windows.Forms.Label();
            this.lbCreateAt = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnShowAOrder = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OrderManagement.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.grbOrderDetail.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderManagement
            // 
            this.OrderManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.OrderManagement, 2);
            this.OrderManagement.Controls.Add(this.tableLayoutPanel2);
            this.OrderManagement.Location = new System.Drawing.Point(6, 6);
            this.OrderManagement.Margin = new System.Windows.Forms.Padding(6);
            this.OrderManagement.Name = "OrderManagement";
            this.OrderManagement.Padding = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.SetRowSpan(this.OrderManagement, 2);
            this.OrderManagement.Size = new System.Drawing.Size(1309, 680);
            this.OrderManagement.TabIndex = 3;
            this.OrderManagement.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.39453F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.60547F));
            this.tableLayoutPanel2.Controls.Add(this.dgvOrder, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.grbOrderDetail, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnShowAOrder, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(9, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1291, 652);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // dgvOrder
            // 
            this.dgvOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(6, 331);
            this.dgvOrder.Margin = new System.Windows.Forms.Padding(6);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersVisible = false;
            this.dgvOrder.RowHeadersWidth = 51;
            this.tableLayoutPanel2.SetRowSpan(this.dgvOrder, 2);
            this.dgvOrder.Size = new System.Drawing.Size(870, 315);
            this.dgvOrder.TabIndex = 0;
            this.dgvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClickItem);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(521, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "QUẢN LÝ HOÁ ĐƠN";
            // 
            // grbOrderDetail
            // 
            this.grbOrderDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grbOrderDetail.Controls.Add(this.lbOrderID);
            this.grbOrderDetail.Controls.Add(this.lbCusID);
            this.grbOrderDetail.Controls.Add(this.lbUserID);
            this.grbOrderDetail.Controls.Add(this.lbCreateAt);
            this.grbOrderDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.grbOrderDetail.Location = new System.Drawing.Point(885, 133);
            this.grbOrderDetail.Name = "grbOrderDetail";
            this.grbOrderDetail.Size = new System.Drawing.Size(397, 189);
            this.grbOrderDetail.TabIndex = 7;
            this.grbOrderDetail.TabStop = false;
            this.grbOrderDetail.Text = "Thông tin hoá đơn";
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Location = new System.Drawing.Point(9, 26);
            this.lbOrderID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(101, 20);
            this.lbOrderID.TabIndex = 3;
            this.lbOrderID.Text = "Mã hóa đơn: ";
            // 
            // lbCusID
            // 
            this.lbCusID.AutoSize = true;
            this.lbCusID.Location = new System.Drawing.Point(9, 88);
            this.lbCusID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbCusID.Name = "lbCusID";
            this.lbCusID.Size = new System.Drawing.Size(126, 20);
            this.lbCusID.TabIndex = 5;
            this.lbCusID.Text = "Mã khách hàng: ";
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Location = new System.Drawing.Point(9, 119);
            this.lbUserID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(107, 20);
            this.lbUserID.TabIndex = 6;
            this.lbUserID.Text = "Mã nhân viên:";
            // 
            // lbCreateAt
            // 
            this.lbCreateAt.AutoSize = true;
            this.lbCreateAt.Location = new System.Drawing.Point(9, 57);
            this.lbCreateAt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbCreateAt.Name = "lbCreateAt";
            this.lbCreateAt.Size = new System.Drawing.Size(74, 20);
            this.lbCreateAt.TabIndex = 4;
            this.lbCreateAt.Text = "Ngày lập:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.dtpFrom, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.dtpTo, 1, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 133);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(876, 189);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lọc hóa đơn";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(142, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Từ ngày";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(574, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "Đến ngày";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtpFrom.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(75, 77);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 26);
            this.dtpFrom.TabIndex = 3;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.onDateFromChange);
            // 
            // dtpTo
            // 
            this.dtpTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtpTo.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(513, 77);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 26);
            this.dtpTo.TabIndex = 4;
            this.dtpTo.ValueChanged += new System.EventHandler(this.onDateChange);
            // 
            // btnShowAOrder
            // 
            this.btnShowAOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnShowAOrder.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnShowAOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAOrder.ForeColor = System.Drawing.Color.White;
            this.btnShowAOrder.Location = new System.Drawing.Point(990, 438);
            this.btnShowAOrder.Margin = new System.Windows.Forms.Padding(6);
            this.btnShowAOrder.Name = "btnShowAOrder";
            this.btnShowAOrder.Size = new System.Drawing.Size(192, 44);
            this.btnShowAOrder.TabIndex = 1;
            this.btnShowAOrder.Text = "Xem đơn hàng";
            this.btnShowAOrder.UseVisualStyleBackColor = false;
            this.btnShowAOrder.Click += new System.EventHandler(this.btnShowAOrder_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.OrderManagement, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 14);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1321, 692);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // frmManagementOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1347, 720);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmManagementOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hoá đơn";
            this.Load += new System.EventHandler(this.frmManagementOrder_Load);
            this.OrderManagement.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.grbOrderDetail.ResumeLayout(false);
            this.grbOrderDetail.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox OrderManagement;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbOrderDetail;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.Label lbCusID;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label lbCreateAt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnShowAOrder;
    }
}