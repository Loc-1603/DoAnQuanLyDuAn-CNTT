using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp_Entity_Store_Management.Business
{
    public class SupplierBusiness
    {
        private readonly StoreModelContainer _context;

        public SupplierBusiness()
        {
            _context = new StoreModelContainer();
        }

        public List<Supplier> GetAllSuppliers()
        {
            var suppliers = _context.Suppliers.ToList();
            SimpleLog.WriteLog($"Lấy danh sách nhà cung cấp: {suppliers.Count} nhà cung cấp");
            return suppliers;
        }

        public void AddSupplier(Supplier supplier)
        {
            _context.Suppliers.Add(supplier);
            _context.SaveChanges();
            SimpleLog.WriteLog($"Thêm nhà cung cấp mới: {supplier.Name}");
        }

        public void UpdateSupplier(Supplier supplier)
        {
            var existingSupplier = _context.Suppliers.Find(supplier.Id);
            if (existingSupplier != null)
            {
                existingSupplier.Name = supplier.Name;
                existingSupplier.Phone = supplier.Phone;
                existingSupplier.Email = supplier.Email;
                existingSupplier.Address = supplier.Address;
                _context.SaveChanges();
                SimpleLog.WriteLog($"Cập nhật thông tin nhà cung cấp: {supplier.Name}");
            }
        }

        public void DeleteSupplier(int id)
        {
            var supplier = _context.Suppliers.Find(id);
            if (supplier != null)
            {
                _context.Suppliers.Remove(supplier);
                _context.SaveChanges();
                SimpleLog.WriteLog($"Xóa nhà cung cấp: {supplier.Name}");
            }
        }

        public List<Supplier> SearchSuppliers(string keyword)
        {
            var suppliers = _context.Suppliers
                .Where(s => s.Name.Contains(keyword) || 
                           s.Phone.Contains(keyword) || 
                           s.Email.Contains(keyword) ||
                           s.Address.Contains(keyword))
                .ToList();
            SimpleLog.WriteLog($"Tìm kiếm nhà cung cấp với từ khóa '{keyword}': tìm thấy {suppliers.Count} nhà cung cấp");
            return suppliers;
        }
    }
} 