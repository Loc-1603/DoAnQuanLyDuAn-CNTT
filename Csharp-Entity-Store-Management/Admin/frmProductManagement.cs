using System;
using System.Windows.Forms;
using Csharp_Entity_Store_Management.Business;

namespace Csharp_Entity_Store_Management.Admin
{
    public partial class frmProductManagement : Form
    {
        private readonly ProductBusiness _productBusiness;
        private readonly StoreModelContainer _context;

        public frmProductManagement()
        {
            InitializeComponent();
            _productBusiness = new ProductBusiness();
            _context = new StoreModelContainer();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                // Load products
                var products = _productBusiness.GetAllProducts();
                dataGridViewProducts.DataSource = products;

                // Load categories for ComboBox
                var categories = _context.Categories.ToList();
                cboCategory.DataSource = categories;
                cboCategory.DisplayMember = "Name";
                cboCategory.ValueMember = "Id";

                // Load suppliers for ComboBox
                var suppliers = _context.Suppliers.ToList();
                cboSupplier.DataSource = suppliers;
                cboSupplier.DisplayMember = "Name";
                cboSupplier.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var product = new Product
                {
                    Name = txtName.Text,
                    Description = txtDescription.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    CategoryId = (int)cboCategory.SelectedValue,
                    SupplierId = (int)cboSupplier.SelectedValue
                };

                _productBusiness.AddProduct(product);
                LoadData();
                MessageBox.Show("Product added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewProducts.SelectedRows.Count > 0)
                {
                    var product = (Product)dataGridViewProducts.SelectedRows[0].DataBoundItem;
                    product.Name = txtName.Text;
                    product.Description = txtDescription.Text;
                    product.Price = decimal.Parse(txtPrice.Text);
                    product.Quantity = int.Parse(txtQuantity.Text);
                    product.CategoryId = (int)cboCategory.SelectedValue;
                    product.SupplierId = (int)cboSupplier.SelectedValue;

                    _productBusiness.UpdateProduct(product);
                    LoadData();
                    MessageBox.Show("Product updated successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewProducts.SelectedRows.Count > 0)
                {
                    var product = (Product)dataGridViewProducts.SelectedRows[0].DataBoundItem;
                    if (MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        _productBusiness.DeleteProduct(product.Id);
                        LoadData();
                        MessageBox.Show("Product deleted successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting product: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var keyword = txtSearch.Text;
                var products = _productBusiness.SearchProducts(keyword);
                dataGridViewProducts.DataSource = products;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching products: " + ex.Message);
            }
        }

        private void btnStockIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewProducts.SelectedRows.Count > 0)
                {
                    var product = (Product)dataGridViewProducts.SelectedRows[0].DataBoundItem;
                    var quantity = int.Parse(txtStockInQuantity.Text);

                    // Update product quantity directly
                    product.Quantity += quantity;
                    _productBusiness.UpdateProduct(product);

                    // Add stock in record
                    var stockIn = new StockIn
                    {
                        ProductId = product.Id,
                        SupplierId = product.SupplierId,
                        Quantity = quantity,
                        Date = DateTime.Now
                    };
                    _context.StockIns.Add(stockIn);
                    _context.SaveChanges();

                    LoadData();
                    MessageBox.Show("Stock in added successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding stock in: " + ex.Message);
            }
        }
    }
} 