## **BÀI TẬP LỚN C# QUẢN LÝ CỬA HÀNG BÁN TẠP HOÁ**

### **NHÓM SINH VIÊN TRƯỜNG ĐẠI HỌC KINH TẾ TP.HCM**

---

### **TÍNH NĂNG:**

* Quản lý sản phẩm.
* Quản lý tài khoản.
* Quản lý danh mục sản phẩm.
* Quản lý nhà cung cấp.
* Quản lý nhập sản phẩm.
* Giao diện bán hàng.
* Xem chi tiết hoá đơn.
* Xuất hoá đơn dạng pdf.
* Nhập xuất dữ liệu qua file excel.

---

### **HƯỚNG DẪN SỬ DỤNG:**

**Bước 1:**

* Mở SQL Server và chạy script trong file db\_store\_management.sql để tạo cơ sở dữ liệu.

**Bước 2:**

* Sao chép tên Server từ máy của bạn hoặc từ nơi lưu trữ online.

**Bước 3:**

* Dán tên Server vào phần cấu hình kết nối cơ sở dữ liệu trong file App.config như sau:

  ```xml
  <connectionStrings>
    <add name="StoreEntities" connectionString="metadata=res://*/StoreModel.csdl|res://*/StoreModel.ssdl|res://*/StoreModel.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=<TÊN SERVER ĐÃ SAO CHÉP>;initial catalog=store_management;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
  </connectionStrings>
  ```

**Bước 4:**

* Khởi động ứng dụng và trải nghiệm.

---

### **NHÓM SINH VIÊN THỰC HIỆN:**

* Đặng Minh Kiên  
* Hồ Xuân Lộc
* Nguyễn Nhật Khang
