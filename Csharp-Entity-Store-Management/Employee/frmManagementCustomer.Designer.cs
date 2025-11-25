
namespace Csharp_Entity_Store_Management
{
    partial class frmManagementCustomer
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
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.txtCusAddress = new System.Windows.Forms.TextBox();
            this.lblCusID = new System.Windows.Forms.Label();
            this.lblCusPhone = new System.Windows.Forms.Label();
            this.lblCusName = new System.Windows.Forms.Label();
            this.lblCusAddress = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCusID
            // 
            this.txtCusID.Location = new System.Drawing.Point(153, 90);
            this.txtCusID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.ReadOnly = true;
            this.txtCusID.Size = new System.Drawing.Size(201, 26);
            this.txtCusID.TabIndex = 9;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(153, 148);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(201, 26);
            this.txtPhone.TabIndex = 10;
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(153, 207);
            this.txtCusName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(201, 26);
            this.txtCusName.TabIndex = 5;
            // 
            // txtCusAddress
            // 
            this.txtCusAddress.Location = new System.Drawing.Point(153, 265);
            this.txtCusAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCusAddress.Name = "txtCusAddress";
            this.txtCusAddress.Size = new System.Drawing.Size(201, 26);
            this.txtCusAddress.TabIndex = 6;
            // 
            // lblCusID
            // 
            this.lblCusID.AutoSize = true;
            this.lblCusID.Location = new System.Drawing.Point(32, 95);
            this.lblCusID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCusID.Name = "lblCusID";
            this.lblCusID.Size = new System.Drawing.Size(61, 20);
            this.lblCusID.TabIndex = 1;
            this.lblCusID.Text = "Mã KH:";
            // 
            // lblCusPhone
            // 
            this.lblCusPhone.AutoSize = true;
            this.lblCusPhone.Location = new System.Drawing.Point(32, 149);
            this.lblCusPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCusPhone.Name = "lblCusPhone";
            this.lblCusPhone.Size = new System.Drawing.Size(106, 20);
            this.lblCusPhone.TabIndex = 2;
            this.lblCusPhone.Text = "Số điện thoại:";
            // 
            // lblCusName
            // 
            this.lblCusName.AutoSize = true;
            this.lblCusName.Location = new System.Drawing.Point(32, 207);
            this.lblCusName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCusName.Name = "lblCusName";
            this.lblCusName.Size = new System.Drawing.Size(61, 20);
            this.lblCusName.TabIndex = 3;
            this.lblCusName.Text = "Họ tên:";
            // 
            // lblCusAddress
            // 
            this.lblCusAddress.AutoSize = true;
            this.lblCusAddress.Location = new System.Drawing.Point(32, 272);
            this.lblCusAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCusAddress.Name = "lblCusAddress";
            this.lblCusAddress.Size = new System.Drawing.Size(61, 20);
            this.lblCusAddress.TabIndex = 4;
            this.lblCusAddress.Text = "Địa chỉ:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(74, 340);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 35);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(227, 340);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 35);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(31, 29);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(335, 25);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Cập nhật thông tin khách hàng";
            // 
            // frmManagementCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 418);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblCusAddress);
            this.Controls.Add(this.lblCusName);
            this.Controls.Add(this.lblCusPhone);
            this.Controls.Add(this.lblCusID);
            this.Controls.Add(this.txtCusAddress);
            this.Controls.Add(this.txtCusName);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtCusID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmManagementCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManagementCustomer";
            this.Load += new System.EventHandler(this.frmManagementCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCusID;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.TextBox txtCusAddress;
        private System.Windows.Forms.Label lblCusID;
        private System.Windows.Forms.Label lblCusPhone;
        private System.Windows.Forms.Label lblCusName;
        private System.Windows.Forms.Label lblCusAddress;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblHeading;
    }
}