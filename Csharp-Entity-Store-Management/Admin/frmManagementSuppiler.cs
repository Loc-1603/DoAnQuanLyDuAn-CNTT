using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace Csharp_Entity_Store_Management
{
    public partial class frmManagementSuppiler : Form
    {
        StoreEntities StoreEntities;
        public frmManagementSuppiler()
        {
            InitializeComponent();
            StoreEntities = new StoreEntities();
            dataGridViewSupplier.RowTemplate.Height = 25;
        }

        private void LoadData()
        {
            dataGridViewSupplier.DataSource = StoreEntities.Suppliers
                .Select(s => new
                {
                    s.supplierID,
                    s.name,
                    s.address,
                    s.createdAt,
                    s.updatedAt
                }).ToList();
        }
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            string tenNCC = txtTenNCC.Text;
            string diaChi = txtDCNCC.Text;

            if (string.IsNullOrEmpty(tenNCC) || string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Bạn cần điền đầy đủ thông tin",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Supplier supplier = new Supplier();
                    supplier.name = tenNCC;
                    supplier.address = diaChi;

                    StoreEntities.Suppliers.Add(supplier);
                    StoreEntities.SaveChanges();
                    txtMaNCC.Text = supplier.supplierID + "";
                    LoadData();
                    LoadDataSourceCbx();
                    MessageBox.Show("Thêm nhà cung cấp thành công", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Lỗi: " + exp.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridViewSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtMaNCC.Text = dataGridViewSupplier.Rows[row].Cells[0].Value + "";
            txtTenNCC.Text = dataGridViewSupplier.Rows[row].Cells[1].Value + "";
            txtDCNCC.Text = dataGridViewSupplier.Rows[row].Cells[2].Value + "";
        }

        private void frmManagementSuppiler_Load(object sender, EventArgs e)
        {
            LoadData();
            txtMaNCC.ReadOnly = true;
            SetWidth();
            LoadDataSourceCbx();
            txtSearchKeyword.GotFocus += TxtSearchKeyword_GotFocus;
        }

        private void TxtSearchKeyword_GotFocus(object sender, EventArgs e)
        {
            txtSearchKeyword.Text = "";
            txtSearchKeyword.ForeColor = Color.Black;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void btnDelSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                int removeID = int.Parse(txtMaNCC.Text);
                Supplier supplier = StoreEntities.Suppliers.
                    SingleOrDefault(s => s.supplierID == removeID);
                StoreEntities.Entry(supplier).State = System.Data.Entity.EntityState.Deleted;
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Cảnh báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult.Equals(DialogResult.Yes))
                {
                    StoreEntities.SaveChanges();
                    ClearTextBoxes();
                    LoadData();
                    LoadDataSourceCbx();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Lỗi: " + exp.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ClearTextBoxes()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDCNCC.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                int updateID = int.Parse(txtMaNCC.Text);
                Supplier supplier = StoreEntities.Suppliers.
                    SingleOrDefault(s => s.supplierID == updateID);

                supplier.name = txtTenNCC.Text;
                supplier.address = txtDCNCC.Text;
                if (string.IsNullOrEmpty(supplier.name) || string.IsNullOrEmpty(supplier.address))
                {
                    MessageBox.Show("Bạn cần điền đầy đủ thông tin",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ClearTextBoxes();
                    StoreEntities.SaveChanges();
                    LoadData();
                    LoadDataSourceCbx();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Lỗi: " + exp.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SetWidth()
        {
            dataGridViewSupplier.Columns[0].Width = 70;
            dataGridViewSupplier.Columns[1].Width = 190;
            dataGridViewSupplier.Columns[2].Width = 90;
            dataGridViewSupplier.Columns[3].Width = 160;
            dataGridViewSupplier.Columns[4].Width = 180;
            dataGridViewSupplier.Columns[0].HeaderText = "Mã NCC";
            dataGridViewSupplier.Columns[1].HeaderText = "Tên NCC";
            dataGridViewSupplier.Columns[2].HeaderText = "Địa chỉ";
            dataGridViewSupplier.Columns[3].HeaderText = "Ngày tạo";
            dataGridViewSupplier.Columns[4].HeaderText = "Ngày cập nhật";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                cbxAddress.SelectedIndex = 0;
                string tenNCC = txtSearchKeyword.Text;
                dataGridViewSupplier.DataSource = StoreEntities.Suppliers.
                    Where(s => s.name.Contains(tenNCC)).Select(s => new
                    {
                        s.supplierID,
                        s.name,
                        s.address,
                        s.createdAt,
                        s.updatedAt
                    }).ToList();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Lỗi: " + exp.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            LoadData();
            cbxAddress.SelectedIndex = 0;
        }
        private void LoadDataSourceCbx()
        {
            HashSet<string> source = new HashSet<string>() { "All" };
            HashSet<string> address = StoreEntities.Suppliers.Select(s => s.address).ToHashSet();
            foreach (string dc in address)
            {
                source.Add(dc);
            }
            cbxAddress.DataSource = source.ToList();
        }

        private void cbxAddress_SelectedValueChanged(object sender, EventArgs e)
        {
            string address = cbxAddress.Text.ToLower();
            if (address.Equals("all"))
            {
                LoadData();
            }
            else
            {
                try
                {
                    dataGridViewSupplier.DataSource = StoreEntities.Suppliers.
                Where(s => s.address.ToLower().Equals(address)).Select(s => new
                {
                    s.supplierID,
                    s.name,
                    s.address,
                    s.createdAt,
                    s.updatedAt
                }).ToList();
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Lỗi: " + exp.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewSupplier.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                    excelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < dataGridViewSupplier.Columns.Count + 1; i++)
                    {
                        excelApp.Cells[1, i] = dataGridViewSupplier.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < dataGridViewSupplier.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridViewSupplier.Columns.Count; j++)
                        {

                            excelApp.Cells[i + 2, j + 1] = dataGridViewSupplier.Rows[i].Cells[j].Value.ToString();
                        }

                    }
                    excelApp.Columns.AutoFit();
                    excelApp.Visible = true;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Lỗi: " + exp.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            _Application importApp;
            _Workbook importWorkbook;
            _Worksheet importWorksheet;
            Range importRange;

            try
            {
                importApp = new Microsoft.Office.Interop.Excel.Application();
                OpenFileDialog importOpenFileDialog = new OpenFileDialog();
                importOpenFileDialog.Title = "Import Excel file to data";
                importOpenFileDialog.Filter = "Choose Excel File | *.xlsx; *.xls; *.xlm";
                if (importOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    importWorkbook = importApp.Workbooks.Open(importOpenFileDialog.FileName);
                    importWorksheet = importWorkbook.ActiveSheet;
                    importRange = importWorksheet.UsedRange;

                    for (int excelWorkSheetRowIndex = 2; excelWorkSheetRowIndex < importRange.Rows.Count + 1; excelWorkSheetRowIndex++)
                    {
                        string tenNCC = Convert.ToString(importWorksheet.Cells[excelWorkSheetRowIndex, 2].Value);
                        string diaChi = Convert.ToString(importWorksheet.Cells[excelWorkSheetRowIndex, 3].Value);
                        if (string.IsNullOrWhiteSpace(tenNCC) || string.IsNullOrWhiteSpace(diaChi) ||
                            string.IsNullOrEmpty(tenNCC) || string.IsNullOrEmpty(diaChi))
                        {
                            continue;
                        }
                        Supplier supplier = StoreEntities.Suppliers.Where(s => s.name.Equals(tenNCC) && s.address.Equals(diaChi)).SingleOrDefault();
                        if (supplier == null)
                        {
                            Supplier supplierAdd = new Supplier();
                            supplierAdd.name = tenNCC;
                            supplierAdd.address = diaChi;

                            StoreEntities.Suppliers.Add(supplierAdd);
                            StoreEntities.SaveChanges();
                            txtMaNCC.Text = supplierAdd.supplierID + "";
                            txtTenNCC.Text = supplierAdd.name;
                            txtDCNCC.Text = supplierAdd.address;
                            LoadData();
                            LoadDataSourceCbx();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Cảnh báo");
            }
        }
    }

}

