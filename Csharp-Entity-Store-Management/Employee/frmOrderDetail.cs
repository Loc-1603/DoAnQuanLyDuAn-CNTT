using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Globalization;

namespace Csharp_Entity_Store_Management
{
    public partial class frmOrderDetail : Form
    {
        private int orderID;
        StoreEntities data = new StoreEntities();
        public frmOrderDetail()
        {
            InitializeComponent();
        }

        public int OrderID { get => orderID; set => orderID = value; }

        private void frmOrderDetail_Load(object sender, EventArgs e)
        {
            getAllInfor();
            getAllProduct();
        }
        public void getAllInfor()
        {
            Order order = data.Orders.Where(p => p.orderID == orderID).SingleOrDefault();
            lbOrderID.Text = lbOrderID.Text + order.orderID;
            lbTotalMoney.Text = lbTotalMoney.Text+ string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", order.totalAmount) +" vnđ";
            String[] date = order.createdAt.ToString().Split(' ');
            lbDate.Text = lbDate.Text + date[0];
            User user = data.Users.Where(p => p.userID == order.userID).SingleOrDefault();
            lbUserID.Text = lbUserID.Text + user.userID;
            lbUsername.Text = lbUsername.Text + user.fullname;
            Customer customer = data.Customers.Where(p => p.customerID == order.customerID).SingleOrDefault();
            lbCustomerName.Text = lbCustomerName.Text + customer.name;
            lbCustomerAddress.Text = lbCustomerAddress.Text + customer.address;
            lbCustomerPhone.Text = lbCustomerPhone.Text + customer.phone;
        }
        public void getAllProduct()
        {
            //nối 2 bảng và tìm tất cả các sản phẩm trong OrderDetails theo OrderID
            var result = (from a in data.OrderDetails.Where(a => a.orderID == orderID)
                          from b in data.Products.Where(b => b.productID == a.productID)
                          select new
                          {
                              maHang = a.productID,
                              tenHang = b.name,
                              soLuong = a.quantity,
                              donGia = a.price,
                              giamGia = a.discount,
                              thanhTien = a.price * a.quantity - a.price*a.quantity*a.discount/100
                          }).ToList();
            dgvListProduct.DataSource = result;
            dgvListProduct.Columns[0].HeaderText = "Mã hàng";
            dgvListProduct.Columns[1].HeaderText = "Tên hàng";
            dgvListProduct.Columns[2].HeaderText = "Số lượng";
            dgvListProduct.Columns[3].HeaderText = "Đơn giá";
            dgvListProduct.Columns[4].HeaderText = "Giảm giá";
            dgvListProduct.Columns[5].HeaderText = "Thành tiền";
            dgvListProduct.Columns[5].DefaultCellStyle.Format = "#,### vnđ";


        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            createPDF();
        }
        public void createPDF()
        {
            String filename = "HD" + orderID;
            var savefile = new SaveFileDialog();
            savefile.FileName = filename;
            savefile.DefaultExt = ".pdf";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                //set up để sẵn sàng tạo file và thêm dữ liệu
                Document document = new Document(PageSize.A4, 10f, 20f, 20f, 20f);
                Stream stream = new FileStream(savefile.FileName, FileMode.Create);
                PdfWriter.GetInstance(document, stream);
                document.Open();
                // tạo bảng tương tự TableLayoutPanel
                PdfPTable table = new PdfPTable(3);
                float[] columnsWidth = { 2, 2, 1 };
                table.SetWidths(columnsWidth);
                table.DefaultCell.BorderWidth = 0;
                table.DefaultCell.Padding = 10;
                table.WidthPercentage = 100;
                table.HorizontalAlignment = Element.ALIGN_LEFT;
                //Font chữ
                //String path2 = @"G:\Onlineeeeeeeeee\CSharp\BTL\Store_managment\Project-Csharp-Entity-Store-Management\Csharp-Entity-Store-Management\Csharp-Entity-Store-Management\Resources\font.ttf";
                //String path1 = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Resources\font.ttf";//về trước folder resource
                string path = Path.Combine(Path.GetFullPath(@"..\..\"), "Resources")+@"\font.ttf";
                BaseFont baseFont = BaseFont.CreateFont(path, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 10, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font fontHearder = new iTextSharp.text.Font(baseFont, 15, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font fontBold = new iTextSharp.text.Font(baseFont, 10, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font font8 = new iTextSharp.text.Font(baseFont, 8, iTextSharp.text.Font.NORMAL);
                //Ngày bán
                Phrase phrase1 = new Phrase(lbDate.Text, font8);
                PdfPCell pdfPCell1 = new PdfPCell(phrase1);
                pdfPCell1.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell1.Colspan = 1;
                pdfPCell1.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfPCell1.Padding = 10;

                table.AddCell(pdfPCell1);
                //Chi tiết hóa đơn
                Phrase phrase2 = new Phrase("Chi tiết hóa đơn", fontHearder);
                PdfPCell pdfPCell2 = new PdfPCell(phrase2);
                pdfPCell2.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell2.Colspan = 1;
                pdfPCell2.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfPCell2.PaddingBottom = 25;
                pdfPCell2.PaddingLeft = 20;
                table.AddCell(pdfPCell2);
                //Mã hóa đơn
                Phrase phrase3 = new Phrase(lbOrderID.Text, font8);
                PdfPCell pdfPCell3 = new PdfPCell(phrase3);
                pdfPCell3.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell3.Colspan = 1;
                pdfPCell3.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfPCell3.Padding = 10;
                table.AddCell(pdfPCell3);
                //Tên khách hàng
                Phrase phrase4 = new Phrase(lbCustomerName.Text, font);
                PdfPCell pdfPCell4 = new PdfPCell(phrase4);
                pdfPCell4.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell4.Colspan = 1;
                pdfPCell4.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfPCell4.PaddingLeft = 40;
                pdfPCell4.PaddingBottom = 5;
                table.AddCell(pdfPCell4);
                //Mã nhân viên
                Phrase phrase5 = new Phrase(lbUserID.Text, font);
                PdfPCell pdfPCell5 = new PdfPCell(phrase5);
                pdfPCell5.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell5.Colspan = 2;
                pdfPCell5.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfPCell5.PaddingLeft = 40;
                pdfPCell4.PaddingBottom = 5;
                table.AddCell(pdfPCell5);
                //Địa chỉ
                Phrase phrase6 = new Phrase(lbCustomerAddress.Text, font);
                PdfPCell pdfPCell6 = new PdfPCell(phrase6);
                pdfPCell6.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell6.Colspan = 1;
                pdfPCell6.PaddingLeft = 40;
                pdfPCell4.PaddingBottom = 5;
                pdfPCell6.HorizontalAlignment = Element.ALIGN_LEFT;
                table.AddCell(pdfPCell6);
                //Tên nhân viên
                Phrase phrase7 = new Phrase(lbUsername.Text, font);
                PdfPCell pdfPCell7 = new PdfPCell(phrase7);
                pdfPCell7.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell7.Colspan = 2;
                pdfPCell7.PaddingLeft = 40;
                pdfPCell4.PaddingBottom = 5;
                pdfPCell7.HorizontalAlignment = Element.ALIGN_LEFT;
                table.AddCell(pdfPCell7);
                //Số điện thoại
                Phrase phrase8 = new Phrase(lbCustomerPhone.Text, font);
                PdfPCell pdfPCell8 = new PdfPCell(phrase8);
                pdfPCell8.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell8.Colspan = 3;
                pdfPCell8.PaddingLeft = 40;
                pdfPCell8.PaddingTop = 5;
                pdfPCell8.HorizontalAlignment = Element.ALIGN_LEFT;
                table.AddCell(pdfPCell8);
                //table sản phẩm
                PdfPTable tableProduct = new PdfPTable(dgvListProduct.ColumnCount);
                tableProduct.DefaultCell.PaddingBottom = 10;
                tableProduct.DefaultCell.PaddingTop = 10;
                tableProduct.WidthPercentage = 90;
                tableProduct.HorizontalAlignment = Element.ALIGN_CENTER;
                tableProduct.DefaultCell.BorderWidth = 1;
                //add headertext
                foreach(DataGridViewColumn column in dgvListProduct.Columns)
                {
                    PdfPCell pdfPCell = new PdfPCell(new Phrase(column.HeaderText, fontBold));
                    pdfPCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    pdfPCell.PaddingBottom = 2;
                    tableProduct.AddCell(pdfPCell);
                }
                //add cell
                foreach (DataGridViewRow row in dgvListProduct.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        PdfPCell pdfPCell = new PdfPCell(new Phrase(cell.Value.ToString(), font));
                        pdfPCell.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdfPCell.PaddingBottom = 2;
                        tableProduct.AddCell(pdfPCell);
                    }
                }
                //Tổng tiền

                Paragraph para = new Paragraph(lbTotalMoney.Text, font);
                para.Alignment = Element.ALIGN_RIGHT;
                //Blank
                Paragraph parablank = new Paragraph(" ", font);
                //thêm table và đóng
                document.Add(table);
                document.Add(parablank);
                document.Add(tableProduct);
                document.Add(parablank);
                document.Add(para);
                document.Close();
                stream.Close();
                MessageBox.Show("In hóa đơn thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //OpenFileDialog openFileDialog = new OpenFileDialog();
                //openFileDialog.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
                //if (openFileDialog.ShowDialog().Equals(DialogResult.OK))
                //{
                //    openFileDialog.OpenFile();
                //}


            }
        }
    }
}
