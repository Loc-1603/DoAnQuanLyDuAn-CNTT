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
    public partial class frmManagementStockIn : Form
    {
        StoreEntities db = new StoreEntities();
        public frmManagementStockIn()
        {
            InitializeComponent();
        }

        #region methods
        void loadData()
        {
            var result = from c in db.StockIns select new { IDNCC = c.supplierID, IDSP = c.productID, soluong = c.quantity, createAt = c.createdAt, updateAt = c.updatedAt };
            dataNhapKho.DataSource = result.ToList();
            dataNhapKho.Columns[0].HeaderText = "Mã nhà cung cấp";

            dataNhapKho.Columns[1].HeaderText = "Mã hàng";

            dataNhapKho.Columns[2].HeaderText = "Số lượng";
            dataNhapKho.Columns[3].HeaderText = "Ngày nhập";

            dataNhapKho.Columns[4].HeaderText = "Ngày cập nhật";

            txtSoLuong.Clear();

        }
        void addStockIn()
        {
            try
            {
                int idSpThem = Convert.ToInt32(cbTen.SelectedValue);
                int idNCCThem = Convert.ToInt32(cbNCC.SelectedValue);
                StockIn stThem = db.StockIns.Find(idSpThem, idNCCThem);
                if (stThem == null)
                {

                    StockIn st = new StockIn() { productID = idSpThem, supplierID = Convert.ToInt32(cbNCC.SelectedValue), quantity = Convert.ToInt32(txtSoLuong.Text), createdAt = DateTime.Now, updatedAt = DateTime.Now };
                    db.StockIns.Add(st);
                }
                else
                {
                    stThem.quantity += Convert.ToInt32(txtSoLuong.Text);

                }
                Product spThem = db.Products.Find(idSpThem);
                spThem.stockOnHand += Convert.ToInt32(txtSoLuong.Text);
                db.SaveChanges();
                loadData();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi: " + ex.Message, "Cảnh báo");
            }

        }

        #endregion
        #region Events
        private void btnNhap_Click(object sender, EventArgs e)
        {
            int a;
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
                addStockIn();
        }

        private void frmManagementStockIn_Load(object sender, EventArgs e)
        {
            loadData();
            var resultNCC = from c in db.Suppliers select c;
            cbNCC.DataSource = resultNCC.ToList();
            cbNCC.DisplayMember = "name";
            cbNCC.ValueMember = "supplierID";
            var resultSP = from c in db.Products select c;
            cbTen.DataSource = resultSP.ToList();
            cbTen.DisplayMember = "name";
            cbTen.ValueMember = "productID";
        }

        private void dataNhapKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            cbTen.SelectedValue = Convert.ToInt32(dataNhapKho.Rows[d].Cells[1].Value.ToString());
            cbNCC.SelectedValue = Convert.ToInt32(dataNhapKho.Rows[d].Cells[0].Value.ToString());
            txtSoLuong.Text = dataNhapKho.Rows[d].Cells[2].Value.ToString();
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
                        int idNCC = Convert.ToInt32(importWorksheet.Cells[excelWorkSheetRowIndex, 1].Value);

                        int idSP = Convert.ToInt32(importWorksheet.Cells[excelWorkSheetRowIndex, 2].Value);
                        int soLuong = Convert.ToInt32(importWorksheet.Cells[excelWorkSheetRowIndex, 3].Value);
                        Product spThem = db.Products.Where(q => q.productID == idSP).SingleOrDefault();
                        Supplier nccThem = db.Suppliers.Where(q => q.supplierID == idNCC).SingleOrDefault();
                        if (spThem == null)
                        {
                            MessageBox.Show("Lỗi dữ liệu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        if (nccThem == null)
                        {
                            MessageBox.Show("Lỗi dữ liệu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        try
                        {
                            StockIn stThem = db.StockIns.Find(idSP, idNCC);
                            if (stThem == null)
                            {

                                StockIn st = new StockIn() { productID = idSP, supplierID = idNCC, quantity = soLuong, createdAt = DateTime.Now, updatedAt = DateTime.Now };
                                db.StockIns.Add(st);
                            }
                            else
                            {
                                stThem.quantity += soLuong;

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

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataNhapKho.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dataNhapKho.Columns.Count + 1; i++)
                {
                    excelApp.Cells[1, i] = dataNhapKho.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataNhapKho.Rows.Count; i++)
                {
                    for (int j = 0; j < dataNhapKho.Columns.Count; j++)
                    {

                        excelApp.Cells[i + 2, j + 1] = dataNhapKho.Rows[i].Cells[j].Value.ToString();
                    }

                }
                excelApp.Columns.AutoFit();
                excelApp.Visible = true;
            }
        }
        #endregion
    }
}
