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
    public partial class frmLogin : Form
    {
        public static User currentUser;
        public frmLogin()
        {
            InitializeComponent();
        }

        StoreEntities db = new StoreEntities();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            User account = db.Users.Where(u => u.username == username).SingleOrDefault();

            if (account == null)
            {
                MessageBox.Show("Không tồn tại tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!account.password.Equals(password))
            {
                MessageBox.Show("Sai mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            currentUser = account;

            this.Hide();
            if (account.role.Equals("admin"))
            {
                frmDashboard frmDashboard = new frmDashboard();
                frmDashboard.User = account;
                frmDashboard.Closed += (s, args) => this.Close();
                MessageBox.Show("Đăng nhập thành công với quyền quản trị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmDashboard.Show();
            }
            else
            {
                frmSelling frmSelling = new frmSelling();
                frmSelling.User = account;
                frmSelling.Closed += (s, args) => this.Close();
                MessageBox.Show("Đăng nhập thành công với quyền nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmSelling.Show();
            }

        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnLogin.PerformClick();
        }
    }
}
