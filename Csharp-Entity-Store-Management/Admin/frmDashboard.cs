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
    public partial class frmDashboard : Form
    {
        private User user;
        private int index = 1;
        public User User { get => user; set => user = value; }

        public frmDashboard()
        {
            InitializeComponent();
        }
        private void frmDashboard_Load(object sender, EventArgs e)
        {
            clickedButton(index);
            lblUsername.Text = "Xin chào: " + user.fullname + " !";

            panel.Visible = false;

            loadPanel();
            frmStatistics frm = new frmStatistics();
            frm.TopLevel = false;
            panel.Controls.Add(frm);
            //panel.AutoScroll = true;
            panel.BorderStyle = BorderStyle.None;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
        private void loadPanel()
        {
            panel.Controls.Clear();
            panel.Visible = true;
        }

        private void btnSelling_Click(object sender, EventArgs e)
        {
            loadPanel();
            frmSelling frm = new frmSelling();
            frm.TopLevel = false;
            panel.Controls.Add(frm);
            panel.AutoScroll = true;
            panel.BorderStyle = BorderStyle.None;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
        private void btnProductManagement_Click(object sender, EventArgs e)
        {
            defaultButton(index);
            index = 2;
            clickedButton(index);
            loadPanel();
            frmManagementProduct frm = new frmManagementProduct();
            frm.TopLevel = false;
            panel.Controls.Add(frm);
            //panel.AutoScroll = true;
            panel.BorderStyle = BorderStyle.None;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();

        }
        private void btnOrderManagement_Click(object sender, EventArgs e)
        {
            defaultButton(index);
            index = 3;
            clickedButton(index);
            loadPanel();
            frmManagementOrder frm = new frmManagementOrder();
            frm.TopLevel = false;
            panel.Controls.Add(frm);
            //panel.AutoScroll = true;
            panel.BorderStyle = BorderStyle.None;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
        private void btnAccountManagement_Click(object sender, EventArgs e)
        {
            defaultButton(index);
            index = 4;
            clickedButton(index);
            loadPanel();
            frmManagementAccount frm = new frmManagementAccount();
            frm.TopLevel = false;
            panel.Controls.Add(frm);
            //panel.AutoScroll = true;
            panel.BorderStyle = BorderStyle.None;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnCategoryManagement_Click(object sender, EventArgs e)
        {
            defaultButton(index);
            index = 5;
            clickedButton(index);
            loadPanel();
            frmManagementCategory frm = new frmManagementCategory();
            frm.TopLevel = false;
            panel.Controls.Add(frm);
            //panel.AutoScroll = true;
            panel.BorderStyle = BorderStyle.None;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
        private void btnStockInManagement_Click(object sender, EventArgs e)
        {
            defaultButton(index);
            index = 6;
            clickedButton(index);
            loadPanel();
            frmManagementStockIn frm = new frmManagementStockIn();
            frm.TopLevel = false;
            panel.Controls.Add(frm);
            //panel.AutoScroll = true;
            panel.BorderStyle = BorderStyle.None;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
        private void btnSuppilerManagement_Click(object sender, EventArgs e)
        {
            defaultButton(index);
            index = 7;
            clickedButton(index);
            loadPanel();
            frmManagementSuppiler frm = new frmManagementSuppiler();
            frm.TopLevel = false;
            panel.Controls.Add(frm);
            //panel.AutoScroll = true;
            panel.BorderStyle = BorderStyle.None;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmDashboard_Load(sender, e);
            defaultButton(index);
            index = 1;
            clickedButton(index);

        }

        private void defaultButton(int index)
        {
            switch (index)
            {
                case 1: btnDashboard.BackColor = Color.DodgerBlue; break;
                case 2: btnProductManagement.BackColor = Color.DodgerBlue; break;
                case 3: btnOrderManagement.BackColor = Color.DodgerBlue; break;
                case 4: btnAccountManagement.BackColor = Color.DodgerBlue; break;
                case 5: btnCategoryManagement.BackColor = Color.DodgerBlue; break;
                case 6: btnStockInManagement.BackColor = Color.DodgerBlue; break;
                case 7: btnSuppilerManagement.BackColor = Color.DodgerBlue; break;
            }
        }
        private void clickedButton(int index)
        {
            switch (index)
            {
                case 1: btnDashboard.BackColor = Color.FromArgb(6, 82, 221); break;
                case 2: btnProductManagement.BackColor = Color.FromArgb(6, 82, 221); break;
                case 3: btnOrderManagement.BackColor = Color.FromArgb(6, 82, 221); break;
                case 4: btnAccountManagement.BackColor = Color.FromArgb(6, 82, 221); break;
                case 5: btnCategoryManagement.BackColor = Color.FromArgb(6, 82, 221); break;
                case 6: btnStockInManagement.BackColor = Color.FromArgb(6, 82, 221); break;
                case 7: btnSuppilerManagement.BackColor = Color.FromArgb(6, 82, 221); break;
            }
        }
    }
}
