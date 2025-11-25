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
    public partial class frmManagementOrder : Form
    {
        int orderIDTemp = -1;
        StoreEntities data = new StoreEntities();
        public frmManagementOrder()
        {
            InitializeComponent();
        }

        private void frmManagementOrder_Load(object sender, EventArgs e)
        {

            loadData();
            grbOrderDetail.Visible = false;

        }
        public void loadData()
        {
            var result = data.Orders.Select(p => new {
                orderID = p.orderID,
                customerID = p.customerID,
                userId = p.userID,
                createAt = p.createdAt
            }).ToList();

            dgvOrder.DataSource = result.ToList();
            dgvOrder.Columns[0].HeaderText = "Mã hóa đơn";
            dgvOrder.Columns[1].HeaderText = "Mã khách hàng";
            dgvOrder.Columns[2].HeaderText = "Mã nhân viên";
            dgvOrder.Columns[3].HeaderText = "Ngày lập";
        }

        private void cellClickItem(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataGridViewRow = dgvOrder.CurrentRow;
            String orderID = dataGridViewRow.Cells[0].Value.ToString();
            String cusID = dataGridViewRow.Cells[1].Value.ToString();
            String userID = dataGridViewRow.Cells[2].Value.ToString();
            String dateCreate = dataGridViewRow.Cells[3].Value.ToString();
            String[] list = dateCreate.Split(' ');
            orderIDTemp = int.Parse(orderID);

            grbOrderDetail.Visible = true;

            lbOrderID.Text = "Mã hóa đơn:" + orderID;
            lbCusID.Text = "Mã khách hàng: " + cusID;
            lbCreateAt.Text = "Ngày lập: " + list[0];
            lbUserID.Text = "Mã nhân viên: " + userID;
        }

        private void btnShowAOrder_Click(object sender, EventArgs e)
        {
            if (orderIDTemp != -1)
            {
                frmOrderDetail frmOrderDetail = new frmOrderDetail();
                frmOrderDetail.OrderID = orderIDTemp;
                frmOrderDetail.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 hóa đơn để xem!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void onDateChange(object sender, EventArgs e)
        {
            onDateChangeData();
        }

        private void onDateFromChange(object sender, EventArgs e)
        {
            onDateChangeData();
        }
        public void onDateChangeData()
        {
            var result = data.Orders.Select(p => new
            {
                orderID = p.orderID,
                customerID = p.customerID,
                userId = p.userID,
                createAt = p.createdAt
            }).Where(p => p.createAt >= dtpFrom.Value && p.createAt <= dtpTo.Value);
            dgvOrder.DataSource = result.ToList();
        }
    }
}
