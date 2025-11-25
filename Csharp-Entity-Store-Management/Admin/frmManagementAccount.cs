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
    public partial class frmManagementAccount : Form
    {
        StoreEntities StoreEntities;
        static List<string> Roles1;
        static List<string> Roles2;
        public frmManagementAccount()
        {
            InitializeComponent();
            StoreEntities = new StoreEntities();
            Roles1 = new List<string>() { "admin", "user" };
            Roles2 = new List<string>() { "All", "Admin", "User" };

            dataGridViewAccount.RowTemplate.Height = 25;

        }
        private void LoadData()
        {
            dataGridViewAccount.DataSource = StoreEntities.Users.Select(u => new
            {
                u.userID,
                u.username,
                u.password,
                u.role,
                u.fullname,
                u.address,
                u.position,
                u.phone,
            }).ToList();
            LoadSourceCbxViTri();
            LoadSourceCbxDC();
        }

        private void dataGridViewAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtAccountID.Text = dataGridViewAccount.Rows[row].Cells[0].Value + "";
            txtTenTK.Text = dataGridViewAccount.Rows[row].Cells[1].Value + "";
            txtMK.Text = dataGridViewAccount.Rows[row].Cells[2].Value + "";
            cbxQuyen.Text = dataGridViewAccount.Rows[row].Cells[3].Value + "";
            txtHoVaTen.Text = dataGridViewAccount.Rows[row].Cells[4].Value + "";
            txtDC.Text = dataGridViewAccount.Rows[row].Cells[5].Value + "";
            txtViTri.Text = dataGridViewAccount.Rows[row].Cells[6].Value + "";
            txtDT.Text = dataGridViewAccount.Rows[row].Cells[7].Value + "";
        }

        private void frmManagementAccount_Load(object sender, EventArgs e)
        {
            cbxQuyen.DataSource = Roles1;
            cbxRole.DataSource = Roles2;
            LoadData();
            SetWidth();
            txtAccountID.ReadOnly = true;
            cbxQuyen.SelectedIndex = -1;

            txtSearchKeyword.GotFocus += TxtSearchKeyword_GotFocus;
        }


        private void TxtSearchKeyword_GotFocus(object sender, EventArgs e)
        {
            txtSearchKeyword.Text = "";
            txtSearchKeyword.ForeColor = Color.Black;
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.username = txtTenTK.Text;
            user.password = txtMK.Text;
            user.role = cbxQuyen.SelectedValue + "";
            user.fullname = txtHoVaTen.Text;
            user.address = txtDC.Text;
            user.position = txtViTri.Text;
            user.phone = txtDT.Text;

            if (string.IsNullOrEmpty(user.username) || string.IsNullOrEmpty(user.password)
                || string.IsNullOrEmpty(user.role) || string.IsNullOrEmpty(user.fullname)
                || string.IsNullOrEmpty(user.address) || string.IsNullOrEmpty(user.position)
                || string.IsNullOrEmpty(user.phone))
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                User usr = StoreEntities.Users.FirstOrDefault(u => u.username.Equals(user.username));
                if (usr == null)
                {
                    User usr1 = StoreEntities.Users.FirstOrDefault(u => u.phone.Equals(user.phone));
                    if (usr1 == null)
                    {
                        StoreEntities.Users.Add(user);
                        StoreEntities.SaveChanges();
                        txtAccountID.Text = user.userID + "";
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Số điện thoại đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ClearTextBoxes()
        {
            txtAccountID.Text = "";
            txtTenTK.Text = "";
            txtMK.Text = "";
            txtHoVaTen.Text = "";
            txtDC.Text = "";
            txtViTri.Text = "";
            txtDT.Text = "";
            cbxQuyen.SelectedIndex = -1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void btnDelAccount_Click(object sender, EventArgs e)
        {
            int removeID = 0;
            try
            {
                removeID = int.Parse(txtAccountID.Text);
            }
            catch
            {
                MessageBox.Show("Mã tài khoản không chính xác!", "Cảnh báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            User user = StoreEntities.Users.
                SingleOrDefault(u => u.userID == removeID);
            if (user != null)
            {
                if (user.userID == frmLogin.currentUser.userID)
                {
                    MessageBox.Show("Không thể xóa tài khoản đang đăng nhập!", "Cảnh báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    StoreEntities.Entry(user).State = System.Data.Entity.EntityState.Deleted;

                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Cảnh báo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult.Equals(DialogResult.Yes))
                    {
                        StoreEntities.SaveChanges();
                        ClearTextBoxes();
                        LoadData();
                    }
                }
            }
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            int updateID = int.Parse(txtAccountID.Text);
            User user = StoreEntities.Users.
                SingleOrDefault(u => u.userID == updateID);

            user.username = txtTenTK.Text;
            user.password = txtMK.Text;
            user.role = cbxQuyen.SelectedValue + "";
            user.fullname = txtHoVaTen.Text;
            user.address = txtDC.Text;
            user.position = txtViTri.Text;
            user.phone = txtDT.Text;

            if (string.IsNullOrEmpty(user.username) || string.IsNullOrEmpty(user.password)
                || string.IsNullOrEmpty(user.role) || string.IsNullOrEmpty(user.fullname)
                || string.IsNullOrEmpty(user.address) || string.IsNullOrEmpty(user.position)
                || string.IsNullOrEmpty(user.phone))
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                StoreEntities.SaveChanges();
                ClearTextBoxes();
                LoadData();
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void SetWidth()
        {
            dataGridViewAccount.Columns[0].Width = 50;
            dataGridViewAccount.Columns[1].Width = 70;
            dataGridViewAccount.Columns[2].Width = 70;
            dataGridViewAccount.Columns[3].Width = 50;
            dataGridViewAccount.Columns[4].Width = 130;
            dataGridViewAccount.Columns[5].Width = 80;
            dataGridViewAccount.Columns[6].Width = 70;
            dataGridViewAccount.Columns[7].Width = 110;
            dataGridViewAccount.Columns[0].HeaderText = "Mã TK";
            dataGridViewAccount.Columns[1].HeaderText = "Tên TK";
            dataGridViewAccount.Columns[2].HeaderText = "Mật khẩu";
            dataGridViewAccount.Columns[3].HeaderText = "Quyền";
            dataGridViewAccount.Columns[4].HeaderText = "Họ tên";
            dataGridViewAccount.Columns[5].HeaderText = "Địa chỉ";
            dataGridViewAccount.Columns[6].HeaderText = "Vị trí";
            dataGridViewAccount.Columns[7].HeaderText = "Điện thoại";
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            LoadData();
            cbxRole.SelectedIndex = 0;
            cbxPosition.SelectedIndex = 0;
            cbxAddress.SelectedIndex = 0;
        }
        private void Filter()
        {
            string filterWordPosition = cbxPosition.Text.ToLower();
            string filterWordAddress = cbxAddress.Text.ToLower();
            string filterWordRole = cbxRole.Text.ToLower();
            dataGridViewAccount.DataSource = StoreEntities.Users.
                Where(u => (filterWordAddress.Equals("all") == false ?
                u.address.Equals(filterWordAddress) : true)
                && (filterWordPosition.Equals("all") == false
                ? u.position.Equals(filterWordPosition) : true)
                && (filterWordRole.Equals("all") == false ?
                u.role.Equals(filterWordRole) : true)).
                Select(u => new
                {
                    u.userID,
                    u.username,
                    u.password,
                    u.role,
                    u.fullname,
                    u.address,
                    u.position,
                    u.phone,
                }).ToList();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            cbxRole.SelectedIndex = 0;
            cbxAddress.SelectedIndex = 0;
            cbxPosition.SelectedIndex = 0;
            string username = txtSearchKeyword.Text;
            dataGridViewAccount.DataSource = StoreEntities.Users.
                Where(u => u.username.Contains(username)).Select(u => new
                {
                    u.userID,
                    u.username,
                    u.password,
                    u.role,
                    u.fullname,
                    u.address,
                    u.position,
                    u.phone,
                }).ToList();
        }

        private void cbxRole_SelectedValueChanged(object sender, EventArgs e)
        {
            Filter();
        }
        private void LoadSourceCbxViTri()
        {
            HashSet<string> source = new HashSet<string>() { "All" };
            HashSet<string> positions = StoreEntities.Users.Select(s => s.position).ToHashSet();
            foreach (string vitri in positions)
            {
                source.Add(vitri);
            }
            cbxPosition.DataSource = source.ToList();
        }
        private void LoadSourceCbxDC()
        {
            HashSet<string> source = new HashSet<string>() { "All" };
            HashSet<string> address = StoreEntities.Users.Select(s => s.address).ToHashSet();
            foreach (string dc in address)
            {
                source.Add(dc);
            }
            cbxAddress.DataSource = source.ToList();
        }

        private void cbxPosition_SelectedValueChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void cbxAddress_SelectedValueChanged(object sender, EventArgs e)
        {
            Filter();
        }
    }
}
