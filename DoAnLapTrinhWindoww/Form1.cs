using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;

namespace DoAnLapTrinhWindoww
{
    public partial class Form1 : Form
    {
        private readonly ShopEntities db;

        public Form1()
        {
            InitializeComponent();
            db = new ShopEntities();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var totalProduct = db.OrderDetails.Sum(x => x.quantity);
                if (totalProduct.HasValue)
                {
                    lblTotalProduct.Text = totalProduct.Value.ToString();
                }
                else
                {
                    lblTotalProduct.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            db?.Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            try
            {
                var account = db.Users.FirstOrDefault(u => u.username == username);
                if (account != null)
                {
                    // Xử lý khi tìm thấy user
                    return account;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
} 