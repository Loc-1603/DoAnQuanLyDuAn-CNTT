using Microsoft.Office.Interop.Excel;
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
    public partial class frmManagementProduct : Form
    {
        StoreEntities db = new StoreEntities();
        public frmManagementProduct()
        {
            InitializeComponent();
        }
        #region methods
        void loadData()
        {
            var result = from c in db.Products select new { ID = c.productID, tensp = c.name, loai = c.Category.name, soluong = c.stockOnHand, dongia = c.price, ngaytao = c.createdAt, ngaycapnhat = c.updatedAt };
            dataSanPham.DataSource = result.ToList();
            dataSanPham.Columns[0].HeaderText = "ID";

            dataSanPham.Columns[1].HeaderText = "Tên hàng";
            dataSanPham.Columns[2].HeaderText = "Loại hàng";
            dataSanPham.Columns[3].HeaderText = "Số lượng";
            dataSanPham.Columns[4].HeaderText = "Đơn giá";
            dataSanPham.Columns[4].DefaultCellStyle.Format = "#,### vnđ";
            dataSanPham.Columns[5].HeaderText = "Ngày nhập";

            dataSanPham.Columns[6].HeaderText = "Ngày cập nhật";
            txtTen.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();
            txtTen.Focus();

        }
        void addProduct()
        {
            try
            {
                Product spThem = db.Products.Where(q => q.name.Equals(txtTen.Text)).SingleOrDefault();
                if (spThem != null)
                {
                    spThem.stockOnHand += Convert.ToInt32(txtSoLuong.Text);
                    spThem.price = long.Parse(txtDonGia.Text);
                    spThem.categoryID = Convert.ToInt32(cbLoai.SelectedValue);

                    spThem.updatedAt = DateTime.Now;
                }
                else
                {
                    Product sp = new Product() { name = txtTen.Text, stockOnHand = Convert.ToInt32(txtSoLuong.Text), price = long.Parse(txtDonGia.Text), categoryID = Convert.ToInt32(cbLoai.SelectedValue), createdAt = DateTime.Now, updatedAt = DateTime.Now };
                    db.Products.Add(sp);
                }

                db.SaveChanges();
                loadData();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi: " + ex.Message, "Cảnh báo");
            }
        }
        void deleteProduct()
        {
            try
            {

                DialogResult re = MessageBox.Show("Bạn có chắc chắn muốn xoá!", "Cảnh bao", MessageBoxButtons.YesNo);
                if (re == System.Windows.Forms.DialogResult.Yes)
                {
                    int idSpXoa = Convert.ToInt32(dataSanPham.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
                    Product spXoa = db.Products.Where(q => q.productID == idSpXoa).SingleOrDefault();
                    List<StockIn> stXoa = db.StockIns.Where(q => q.productID == idSpXoa).ToList();

                    if (stXoa != null)
                    {
                        foreach (StockIn i in stXoa)
                        {
                            db.StockIns.Remove(i);
                        }
                    }
                    db.Products.Remove(spXoa);
                    db.SaveChanges();
                }
                loadData();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi: " + ex.Message, "Cảnh báo");
            }

        }
        void updateProduct()
        {
            try
            {

                int idSpSua = Convert.ToInt32(dataSanPham.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
                Product spSua = db.Products.Find(idSpSua);

                spSua.name = txtTen.Text;
                spSua.stockOnHand = Convert.ToInt32(txtSoLuong.Text);
                spSua.price = long.Parse(txtDonGia.Text);
                spSua.categoryID = Convert.ToInt32(cbLoai.SelectedValue);

                spSua.updatedAt = DateTime.Now;
                db.SaveChanges();
                loadData();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi: " + ex.Message, "Cảnh báo");
            }

        }
        void findProduct()
        {
            var result = from c in db.Products
                         where c.name == txtTen.Text
                         select new { ID = c.productID, tensp = c.name, loai = c.Category.name, soluong = c.stockOnHand, dongia = c.price, ngaytao = c.createdAt, ngaycapnhat = c.updatedAt };
            dataSanPham.DataSource = result.ToList();
            dataSanPham.Columns[0].HeaderText = "ID";

            dataSanPham.Columns[1].HeaderText = "Tên hàng";
            dataSanPham.Columns[2].HeaderText = "Loại hàng";
            dataSanPham.Columns[3].HeaderText = "Số lượng";
            dataSanPham.Columns[4].HeaderText = "Đơn giá";
            dataSanPham.Columns[5].HeaderText = "Ngày nhập";

            dataSanPham.Columns[6].HeaderText = "Ngày cập nhật";


        }
        #endregion
        #region Events
        private void frmManagementProduct_Load(object sender, EventArgs e)
        {
            loadData();
            var resultLoai = from c in db.Categories select c;
            cbLoai.DataSource = resultLoai.ToList();
            cbLoai.DisplayMember = "name";
            cbLoai.ValueMember = "categoryID";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int a;
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Tên sản phẩm không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show("Số lượng sản phẩm không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!int.TryParse(txtSoLuong.Text, out a))
            {
                MessageBox.Show("Số lương phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (a <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            if (string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                MessageBox.Show("Đơn giá sản phẩm không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!int.TryParse(txtDonGia.Text, out a))
            {
                MessageBox.Show("Đơn giá phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (a <= 0)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                addProduct();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            deleteProduct();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int a;
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Tên sản phẩm không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show("Số lượng sản phẩm không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!int.TryParse(txtSoLuong.Text, out a))
            {
                MessageBox.Show("Số lương phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (a <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            if (string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                MessageBox.Show("Đơn giá sản phẩm không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!int.TryParse(txtDonGia.Text, out a))
            {
                MessageBox.Show("Đơn giá phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (a <= 0)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                updateProduct();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            findProduct();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataSanPham.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dataSanPham.Columns.Count + 1; i++)
                {
                    excelApp.Cells[1, i] = dataSanPham.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataSanPham.Rows.Count; i++)
                {
                    for (int j = 0; j < dataSanPham.Columns.Count; j++)
                    {

                        excelApp.Cells[i + 2, j + 1] = dataSanPham.Rows[i].Cells[j].Value.ToString();
                    }

                }
                excelApp.Columns.AutoFit();
                excelApp.Visible = true;
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

                    //Start Importing from the second row. Since the first row is column header
                    for (int excelWorkSheetRowIndex = 2; excelWorkSheetRowIndex < importRange.Rows.Count + 1; excelWorkSheetRowIndex++)
                    {
                        if (Convert.ToString(importWorksheet.Cells[excelWorkSheetRowIndex, 1].Value) == null)
                            break;
                        string tenSP = Convert.ToString(importWorksheet.Cells[excelWorkSheetRowIndex, 1].Value);
                        string loaiSP = Convert.ToString(importWorksheet.Cells[excelWorkSheetRowIndex, 2].Value);
                        Category loaiThem = db.Categories.Where(q => q.name.Equals(loaiSP)).SingleOrDefault();
                        if (loaiThem == null)
                        {
                            MessageBox.Show("Lỗi dữ liệu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        try
                        {
                            Product spThem = db.Products.Where(q => q.name.Equals(tenSP)).SingleOrDefault();
                            if (spThem != null)
                            {
                                spThem.stockOnHand += Convert.ToInt32(importWorksheet.Cells[excelWorkSheetRowIndex, 3].Value);
                                spThem.price = long.Parse(importWorksheet.Cells[excelWorkSheetRowIndex, 4].Value.ToString());
                                spThem.categoryID = loaiThem.categoryID;
                                spThem.updatedAt = DateTime.Now;
                            }
                            else
                            {
                                Product sp = new Product() { name = tenSP, stockOnHand = Convert.ToInt32(importWorksheet.Cells[excelWorkSheetRowIndex, 3].Value), price = long.Parse(importWorksheet.Cells[excelWorkSheetRowIndex, 4].Value.ToString()), categoryID = loaiThem.categoryID, createdAt = DateTime.Now, updatedAt = DateTime.Now };
                                db.Products.Add(sp);
                            }

                            db.SaveChanges();

                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Có lỗi: " + ex.Message, "Cảnh báo");
                        }
                        //dgvImportExcelToDatagridGridView1.Rows.Add(importWorksheet.Cells[excelWorkSheetRowIndex, 1].Value, importExcelToDataGridViewWorksheet.Cells[excelWorkSheetRowIndex, 2].Value, importExcelToDataGridViewWorksheet.Cells[excelWorkSheetRowIndex, 3].Value, importExcelToDataGridViewWorksheet.Cells[excelWorkSheetRowIndex, 4].Value, importExcelToDataGridViewWorksheet.Cells[excelWorkSheetRowIndex, 5].Value, importExcelToDataGridViewWorksheet.Cells[excelWorkSheetRowIndex, 6].Value, importExcelToDataGridViewWorksheet.Cells[excelWorkSheetRowIndex, 7].Value, excelWorkSheetImage);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Cảnh báo");
            }
            loadData();
        }


        private void btnXem_Click(object sender, EventArgs e)
        {
            loadData();
        }
        #endregion

        private void dataSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtTen.Text = dataSanPham.Rows[d].Cells[1].Value.ToString();
            cbLoai.Text = dataSanPham.Rows[d].Cells[2].Value.ToString();
            txtSoLuong.Text = dataSanPham.Rows[d].Cells[3].Value.ToString();
            txtDonGia.Text = dataSanPham.Rows[d].Cells[4].Value.ToString();
        }
    }
}
