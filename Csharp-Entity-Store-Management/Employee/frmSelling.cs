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
    public partial class frmSelling : Form
    {
        private User user;

        public User User { get => user; set => user = value; }
        public frmSelling()
        {
            InitializeComponent();
        }

        StoreEntities db = new StoreEntities();
        List<ProductInCart> productInCarts = new List<ProductInCart>();
        ProductInCart productInCart = null;

        private void frmSelling_Load(object sender, EventArgs e)
        {
            grbAddCustomer.Visible = false;
            //grbCustomerDetail.Visible = false;
            grbProductDetail.Visible = false;
            dgvCarts.Visible = false;
            lblDetailID.Visible = false;
            lblUserName.Text = "Xin chào: " + user.fullname;

            setDataDgvProducts();

            var categories = db.Categories.Select(c => new
            {
                //categoryID = c.categoryID,
                name = c.name
            }).ToList();

            //cbbCategories.DataSource = categories.ToList();
            //cbbCategories.DisplayMember = "name";
            //cbbCategories.ValueMember = "categoryID";
            cbbCategories.Items.Add("Tất cả");
            foreach (var category in categories)
            {
                cbbCategories.Items.Add(category.name);
            }
            cbbCategories.SelectedIndex = 0;
        }

        private void btnCheckPhone_Click(object sender, EventArgs e)
        {
            grbAddCustomer.Visible = false;
            //grbCustomerDetail.Visible = false;

            string phone = txtCheckPhone.Text;

            if(phone.Length == 0)
            {
                MessageBox.Show("Chưa nhập số điện thoại khách hàng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            getAndSetCusomer(phone);
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string phone = txtCustomerPhone.Text;
            string name = txtCustomerName.Text;
            string address = txtCustomerAddress.Text;

            if(phone.Length == 0 || name.Length == 0 || address.Length == 0)
            {
                MessageBox.Show("Không để trống các trường!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var curCustomer = db.Customers.Select(c => c).Where(c => c.phone == phone).SingleOrDefault();

            if(curCustomer != null)
            {
                MessageBox.Show("Khách hàng đã tồn tại trong hệ thống!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Customer customer = new Customer();
            customer.name = name;
            customer.phone = phone;
            customer.address = address;

            db.Customers.Add(customer);
            db.SaveChanges();
            btnUpdate.Visible = true;
            grbAddCustomer.Visible = false;
            setCustomerDetail(customer);
            //lblCustomerCreatedAt.Text = System.DateTime.Now.ToString();

        }

        private void setCustomerDetail(Customer customer)
        {
            grbAddCustomer.Visible = true;
            txtCustomerName.Text = customer.name;
            txtCustomerName.ReadOnly = true;
            txtCustomerAddress.Text = customer.address;
            txtCustomerAddress.ReadOnly = true;
            txtCustomerPhone.Text = customer.phone;
            txtCustomerPhone.ReadOnly = true;
            btnAddCustomer.Visible = false;
        }

        private void setTitleDgvProducts()
        {
            dgvProducts.Columns[0].HeaderText = "Mã";
            dgvProducts.Columns[0].Width = 80;
            dgvProducts.Columns[1].HeaderText = "Tên sản phẩm";
            dgvProducts.Columns[2].HeaderText = "Số lượng còn";
            dgvProducts.Columns[3].HeaderText = "Giá bán (VNĐ)";
            dgvProducts.Columns[3].DefaultCellStyle.Format = "#,### vnđ";
        }

        private void setDataDgvProducts()
        {
            var products = db.Products.Select(p => new
            {
                productID = p.productID,
                name = p.name,
                stockOnHand = p.stockOnHand,
                price = p.price
            }).Where(p => p.stockOnHand > 0);

            dgvProducts.DataSource = null;
            dgvProducts.DataSource = products.ToList();
            setTitleDgvProducts();
        }

        private void setDataDgvCarts()
        {
            dgvCarts.DataSource = null;
            dgvCarts.DataSource = productInCarts;

            dgvCarts.Columns[0].HeaderText = "Mã";
            dgvCarts.Columns[0].Width = 80;
            dgvCarts.Columns[1].HeaderText = "Tên sản phẩm";
            dgvCarts.Columns[2].HeaderText = "Giá bán (VNĐ)";
            dgvCarts.Columns[3].HeaderText = "Số lượng";
            dgvCarts.Columns[4].HeaderText = "Giảm giá (%)";
            dgvCarts.Columns[5].HeaderText = "Thành tiền (VNĐ)";
            dgvCarts.Columns[2].DefaultCellStyle.Format = "#,### vnđ";
            dgvCarts.Columns[5].DefaultCellStyle.Format = "#,### vnđ";
        }

        private void filterProductByCategory(string categoryName)
        {
            var products = db.Products.Join(db.Categories,
                 p => p.categoryID,
                 c => c.categoryID,
                 (p, c) => new {
                     product = p,
                     category = c
                 })
            .Where(c => c.category.name == categoryName)
            .Select(p => new
            {
                productID = p.product.productID,
                name = p.product.name,
                stockOnHand = p.product.stockOnHand,
                price = p.product.price
            });

            dgvProducts.DataSource = null;
            dgvProducts.DataSource = products.ToList();
            setTitleDgvProducts();
        }

        private int findProductInCart(ProductInCart proInCart)
        {
            for(int i = 0; i < productInCarts.Count; i++)
            {
                if(productInCarts[i].Equals(proInCart))
                {
                    return i;
                }
            }
            return -1;
        }

        private void cbbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = cbbCategories.SelectedItem.ToString();
            if(category.Equals("Tất cả"))
            {
                setDataDgvProducts();
                return;
            }

            filterProductByCategory(category);

        }

        private void selectedProduct(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                dgvCarts.Visible = true;
                lblNotiCart.Visible = false;

                string productID = dgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
                string name = dgvProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
                //string stockOnHand = dgvProducts.Rows[e.RowIndex].Cells[2].Value.ToString();
                string price = dgvProducts.Rows[e.RowIndex].Cells[3].Value.ToString();

                productInCart = new ProductInCart(int.Parse(productID), name, long.Parse(price), 1);
                int index = findProductInCart(productInCart);

                if(index == -1)
                {
                    productInCarts.Add(productInCart);
                    setDataDgvCarts();
                    sumOfMoney();
                    productInCart = null;
                    return;
                }
                int quantity = productInCarts[index].quantity;
                int curQuantity = quantity + 1;
                if (lblDetailID.Text.Equals(productID))
                {
                    txtQuantityDetail.Text = curQuantity.ToString();
                }
                productInCarts[index] = new ProductInCart(productInCart.productID, productInCart.name, productInCart.price, curQuantity);
                setDataDgvCarts();
                sumOfMoney();
                productInCart = null;
            }
        }

        private void viewDetailProduct(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                string ID = dgvCarts.Rows[e.RowIndex].Cells[0].Value.ToString();
                string name = dgvCarts.Rows[e.RowIndex].Cells[1].Value.ToString();
                string price = dgvCarts.Rows[e.RowIndex].Cells[2].Value.ToString();
                string quantity = dgvCarts.Rows[e.RowIndex].Cells[3].Value.ToString();
                int productID = int.Parse(ID);

                var product = db.Products.Select(p => p).Where(p => p.stockOnHand > 0 && p.productID == productID).SingleOrDefault();

                lblDetailID.Text = ID;
                grbProductDetail.Visible = true;
                lblDetailName.Text = name;
                lblDetailPrice.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", long.Parse(price)) + " vnđ";
                lblDetailTotal.Text = product.stockOnHand.ToString();
                txtQuantityDetail.Text = quantity;
            }
        }

        private void updateQuantity(int ID, int quantity)
        {
            ProductInCart prInCart = new ProductInCart(ID, null, 0, 0);
            for(int i = 0; i < productInCarts.Count; i++)
            {
                if (productInCarts[i].CompareID(prInCart))
                {
                    ProductInCart productInCart = productInCarts[i];
                    productInCarts[i] = new ProductInCart(productInCart.productID, productInCart.name, productInCart.price, quantity);
                }
            }
            sumOfMoney();
        }

        private void updateDiscount(int ID, int discount)
        {
            ProductInCart prInCart = new ProductInCart(ID, null, 0, 0);
            for (int i = 0; i < productInCarts.Count; i++)
            {
                if (productInCarts[i].CompareID(prInCart))
                {
                    ProductInCart productInCart = productInCarts[i];
                    productInCarts[i].discount = discount;
                }
            }
            sumOfMoney();
        }

        private void btnDecrement_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(txtQuantityDetail.Text);
            quantity--;
            if(quantity < 1)
            {
                btnDeleteProduct_Click(sender, e);
                return;
            }

            updateQuantity(int.Parse(lblDetailID.Text), quantity);
            txtQuantityDetail.Text = quantity.ToString();

            setDataDgvCarts();
        }

        private void btnIncrement_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(txtQuantityDetail.Text);
            int stockOnHand = int.Parse(lblDetailTotal.Text);
            quantity++;

            if (quantity > stockOnHand)
            {
                MessageBox.Show("Quá số lượng trong kho!", "Thông báo!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            updateQuantity(int.Parse(lblDetailID.Text), quantity);
            txtQuantityDetail.Text = quantity.ToString();

            setDataDgvCarts();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            string name = lblDetailName.Text;

            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xoá sản phẩm khỏi giỏ hàng?", "Thông báo!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            bool status = false;

            if (dialogResult == DialogResult.Yes)
            {
                status = productInCarts.Remove(new ProductInCart(0, name, 0, 0));
            }

            if (!status)
            {
                MessageBox.Show("Xoá thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Xoá thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            grbProductDetail.Visible = false;
            setDataDgvCarts();
            sumOfMoney();
        }

        private long sumOfMoney()
        {
            long sum = 0;
            for(int i = 0; i < productInCarts.Count; i++)
            {
                sum += productInCarts[i].totalAmount;
            }

            lblTotalAmount.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", sum) + " vnđ";

            return sum;
        }

        private long sumOfTotalMoney()
        {
            long sum = 0;
            for (int i = 0; i < productInCarts.Count; i++)
            {
                sum += (productInCarts[i].quantity * productInCarts[i].price);
            }

            return sum;
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtKeyword.Text;

            if(keyword.Length == 0)
            {
                setDataDgvProducts();
                return;
            }

            var products = db.Products.Select(p => new
            {
                productID = p.productID,
                name = p.name,
                stockOnHand = p.stockOnHand,
                price = p.price
            }).Where(p => p.stockOnHand > 0 && p.name.ToLower().Contains(keyword.ToLower()));

            dgvProducts.DataSource = null;
            dgvProducts.DataSource = products.ToList();
            setTitleDgvProducts();
        }

        private void txtQuantityDetail_TextChanged(object sender, EventArgs e)
        {
            string text = txtQuantityDetail.Text;
            if(text.Length == 0){
                text = "0";
            }
            int quantity = int.Parse(text);
            if(quantity == 0)
            {
                btnDeleteProduct_Click(sender, e);
            }
            updateQuantity(int.Parse(lblDetailID.Text), quantity);
            setDataDgvCarts();
        }

        private void btnApplyDiscount_Click(object sender, EventArgs e)
        {
            int discount = int.Parse(txtDiscount.Text);
            txtDiscount.Clear();
            int ID = int.Parse(lblDetailID.Text);

            for(int i = 0; i < productInCarts.Count; i++)
            {
                if(productInCarts[i].productID == ID)
                {
                    productInCarts[i].setDiscount(discount);
                }
            }

            updateDiscount(ID, discount);
            setDataDgvCarts();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

            string phone = txtCustomerPhone.Text;

            if(!txtCustomerPhone.ReadOnly)
            {
                MessageBox.Show("Chưa có thông tin khách hàng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var customer = db.Customers.Select(c => c).Where(c => c.phone == phone).SingleOrDefault();

            if(customer == null)
            {
                MessageBox.Show("Chưa có thông tin khách hàng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(productInCarts.Count == 0)
            {
                MessageBox.Show("Chưa có sản phẩm trong giỏ hàng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Order currentOrder = new Order();
            currentOrder.amount = sumOfTotalMoney();
            currentOrder.totalAmount = sumOfMoney();
            currentOrder.userID = user.userID;
            currentOrder.customerID = customer.customerID;


            db.Orders.Add(currentOrder);
            db.SaveChanges();

            int ID = currentOrder.orderID;

            List<OrderDetail> orderDetails = new List<OrderDetail>();

            for(int i = 0; i < productInCarts.Count; i++)
            {
                ProductInCart prInCart = productInCarts[i];

                OrderDetail orderDetail = new OrderDetail();
                orderDetail.discount = prInCart.discount;
                orderDetail.price = prInCart.price;
                orderDetail.productID = prInCart.productID;
                orderDetail.orderID = ID;
                orderDetail.quantity = prInCart.quantity;

                Product product = db.Products.Find(prInCart.productID);
                product.stockOnHand = product.stockOnHand - prInCart.quantity;

                orderDetails.Add(orderDetail);
            }

            db.OrderDetails.AddRange(orderDetails);
            db.SaveChanges();

            //this.Hide();

            frmOrderDetail frm = new frmOrderDetail();
            frm.OrderID = ID;
            //frm.Closed += (s, args) => this.Close();
            frm.ShowDialog();
            productInCarts = new List<ProductInCart>();
            this.frmSelling_Load(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string phone = txtCustomerPhone.Text;
            frmManagementCustomer frm = new frmManagementCustomer();
            frm.PhoneNumber = phone;
            frm.ShowDialog();
            getAndSetCusomer(phone);
        }

        private void getAndSetCusomer(string phone)
        {
            Customer customer = db.Customers.Select(c => c).Where(c => c.phone == phone).SingleOrDefault();

            if (customer == null)
            {
                grbAddCustomer.Visible = true;
                txtCustomerName.ReadOnly = false;
                txtCustomerAddress.ReadOnly = false;
                txtCustomerPhone.ReadOnly = false;
                txtCustomerName.Clear();
                txtCustomerAddress.Clear();
                txtCheckPhone.Clear();
                btnAddCustomer.Visible = true;
                txtCustomerPhone.Text = phone;
                return;
            }
            txtCheckPhone.Clear();
            btnUpdate.Visible = true;
            setCustomerDetail(customer);
            db = new StoreEntities();
        }


       

        private void btlLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes.Equals(result))
            {
                frmLogin frm = new frmLogin();
                frm.Closed += (s, args) => this.Close();
                frm.Show();
                this.Hide();
            }
            else
            {
                return;
            }
        }
    }
}
