
namespace Csharp_Entity_Store_Management
{
    partial class frmMain
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
            this.btnSupplierForm = new System.Windows.Forms.Button();
            this.btnAccountForm = new System.Windows.Forms.Button();
            this.btnCategoryForm = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnSupplierForm
            // 
            this.btnSupplierForm.Location = new System.Drawing.Point(54, 28);
            this.btnSupplierForm.Name = "btnSupplierForm";
            this.btnSupplierForm.Size = new System.Drawing.Size(90, 23);
            this.btnSupplierForm.TabIndex = 0;
            this.btnSupplierForm.Text = "Nhà cung cấp";
            this.btnSupplierForm.UseVisualStyleBackColor = true;
            this.btnSupplierForm.Click += new System.EventHandler(this.btnSupplierForm_Click);
            // 
            // btnAccountForm
            // 
            this.btnAccountForm.Location = new System.Drawing.Point(174, 28);
            this.btnAccountForm.Name = "btnAccountForm";
            this.btnAccountForm.Size = new System.Drawing.Size(75, 23);
            this.btnAccountForm.TabIndex = 0;
            this.btnAccountForm.Text = "Tài khoản";
            this.btnAccountForm.UseVisualStyleBackColor = true;
            this.btnAccountForm.Click += new System.EventHandler(this.btnAccountForm_Click);
            // 
            // btnCategoryForm
            // 
            this.btnCategoryForm.Location = new System.Drawing.Point(285, 28);
            this.btnCategoryForm.Name = "btnCategoryForm";
            this.btnCategoryForm.Size = new System.Drawing.Size(75, 23);
            this.btnCategoryForm.TabIndex = 0;
            this.btnCategoryForm.Text = "Danh mục";
            this.btnCategoryForm.UseVisualStyleBackColor = true;
            this.btnCategoryForm.Click += new System.EventHandler(this.btnCategoryForm_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(54, 68);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(689, 423);
            this.pnlMain.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 503);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.btnCategoryForm);
            this.Controls.Add(this.btnAccountForm);
            this.Controls.Add(this.btnSupplierForm);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSupplierForm;
        private System.Windows.Forms.Button btnAccountForm;
        private System.Windows.Forms.Button btnCategoryForm;
        private System.Windows.Forms.Panel pnlMain;
    }
}