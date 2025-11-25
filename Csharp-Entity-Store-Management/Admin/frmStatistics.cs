using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Entity_Store_Management
{
    public partial class frmStatistics : Form
    {
        public frmStatistics()
        {
            InitializeComponent();
        }

        StoreEntities db = new StoreEntities();
        private void frmStatistics_Load(object sender, EventArgs e)
        {
            var listCustomer = db.Orders.Join(db.Customers, o => o.customerID, c => c.customerID,
                (o, c) => new
                {
                    TenKH = c.name,
                    SDT = c.phone,
                    Amount = o.totalAmount
                }).GroupBy(x => new
                {
                    TenKH = x.TenKH,
                    SDT = x.SDT
                }).Select(a => new {
                    Ten = a.Key.TenKH,
                    SDT = a.Key.SDT,
                    Tien = a.Sum(t => t.Amount)
                }).OrderByDescending(o => o.Tien);

            dgvCustomers.DataSource = listCustomer.ToList();
            dgvCustomers.Columns[0].HeaderText = "Tên khách hàng";
            dgvCustomers.Columns[1].HeaderText = "Số điện thoại";
            dgvCustomers.Columns[2].HeaderText = "Số tiền đã tiêu";
            dgvCustomers.Columns[2].DefaultCellStyle.Format = "#,### vnđ";

            var listProduct = db.OrderDetails.Join(db.Products, o => o.productID, p => p.productID,
                (o, p) => new
                {
                    TenSP = p.name,
                    DonGia = p.price,
                    SL = o.quantity
                }).GroupBy(x => new
                {
                    TenSP = x.TenSP,
                    DonGia = x.DonGia,
                }).Select(a => new {
                    Ten = a.Key.TenSP,
                    Gia = a.Key.DonGia,
                    SL = a.Sum(t => t.SL)
                }).OrderByDescending(o => o.SL);

            dgvProducts.DataSource = listProduct.ToList();
            dgvProducts.Columns[0].HeaderText = "Tên sản phẩm";
            dgvProducts.Columns[1].HeaderText = "Giá bán";
            dgvProducts.Columns[2].HeaderText = "Số lượng";
            dgvProducts.Columns[1].DefaultCellStyle.Format = "#,### vnđ";

            var totalProductOnHand = db.Products.GroupBy(x => 1).Select(a => new
            {
                SL = a.Sum(t => t.stockOnHand)
            });

            var text1 = totalProductOnHand.SingleOrDefault();

            if (text1 == null)
            {
                lblInventoryNumber.Text = "0 Sản phẩm";
            }
            else
            {
                lblInventoryNumber.Text = text1.SL + " Sản phẩm";
            }

             var totalProduct = db.OrderDetails.GroupBy(x => 1).Select(a => new
            {
                Sl = a.Sum(t => t.quantity)
            }).SingleOrDefault();

            if (totalProduct == null)
            {
                lblSellNumber.Text = "0 Sản phẩm";
            }
            else
            {
                lblSellNumber.Text = totalProduct.Sl + " Sản phẩm";
            }

            var totalAmount = db.Orders.GroupBy(x => 1).Select(a => new
            {
                total = a.Sum(t => t.totalAmount)
            }).SingleOrDefault();

            if (totalAmount == null)
            {
                lblTotalRevenue.Text = 0 + " vnđ";
            }
            else
            {
                lblTotalRevenue.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", totalAmount.total) + " vnđ";
            }

        }
    }
}
