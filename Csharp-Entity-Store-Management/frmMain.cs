using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Entity_Store_Management
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSupplierForm_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            frmManagementSuppiler frmSuppplier = new frmManagementSuppiler();
            frmSuppplier.TopLevel = false;
            pnlMain.Controls.Add(frmSuppplier);
            frmSuppplier.FormBorderStyle = FormBorderStyle.None;
            frmSuppplier.Dock = DockStyle.Fill;
            frmSuppplier.Show();
        }

        private void btnAccountForm_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            frmManagementAccount frmAccount = new frmManagementAccount();
            frmAccount.TopLevel = false;
            pnlMain.Controls.Add(frmAccount);
            frmAccount.FormBorderStyle = FormBorderStyle.None;
            frmAccount.Dock = DockStyle.Fill;
            frmAccount.Show();
        }

        private void btnCategoryForm_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            frmManagementCategory frmCategory = new frmManagementCategory();
            frmCategory.TopLevel = false;
            pnlMain.Controls.Add(frmCategory);
            frmCategory.FormBorderStyle = FormBorderStyle.None;
            frmCategory.Dock = DockStyle.Fill;
            frmCategory.Show();
        }
    }
}
