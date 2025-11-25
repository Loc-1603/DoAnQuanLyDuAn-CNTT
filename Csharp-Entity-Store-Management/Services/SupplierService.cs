using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp_Entity_Store_Management.Services
{
    public class SupplierService
    {
        private readonly StoreModelContainer _context;

        public SupplierService()
        {
            _context = new StoreModelContainer();
        }

        public List<Supplier> GetAllSuppliers()
        {
            return _context.Suppliers.ToList();
        }

        public Supplier GetSupplierById(int id)
        {
            return _context.Suppliers.Find(id);
        }

        public void AddSupplier(Supplier supplier)
        {
            _context.Suppliers.Add(supplier);
            _context.SaveChanges();
        }

        public void UpdateSupplier(Supplier supplier)
        {
            var existingSupplier = _context.Suppliers.Find(supplier.Id);
            if (existingSupplier != null)
            {
                _context.Entry(existingSupplier).CurrentValues.SetValues(supplier);
                _context.SaveChanges();
            }
        }

        public void DeleteSupplier(int id)
        {
            var supplier = _context.Suppliers.Find(id);
            if (supplier != null)
            {
                // Check if supplier has any products
                if (_context.Products.Any(p => p.SupplierId == id))
                {
                    throw new InvalidOperationException("Cannot delete supplier that has products.");
                }
                _context.Suppliers.Remove(supplier);
                _context.SaveChanges();
            }
        }

        public List<Supplier> SearchSuppliers(string keyword)
        {
            return _context.Suppliers
                .Where(s => s.Name.Contains(keyword) || 
                           s.Phone.Contains(keyword) || 
                           s.Email.Contains(keyword) ||
                           s.Address.Contains(keyword))
                .ToList();
        }

        public List<Product> GetProductsBySupplier(int supplierId)
        {
            return _context.Products
                .Where(p => p.SupplierId == supplierId)
                .ToList();
        }
    }
} 