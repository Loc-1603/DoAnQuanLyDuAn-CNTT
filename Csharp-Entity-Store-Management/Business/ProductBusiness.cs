using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp_Entity_Store_Management.Business
{
    public class ProductBusiness
    {
        private readonly StoreModelContainer _context;

        public ProductBusiness()
        {
            _context = new StoreModelContainer();
        }

        public List<Product> GetAllProducts()
        {
            var products = _context.Products.ToList();
            SimpleLog.WriteLog($"Lấy danh sách sản phẩm: {products.Count} sản phẩm");
            return products;
        }

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            SimpleLog.WriteLog($"Thêm sản phẩm mới: {product.Name}");
        }

        public void UpdateProduct(Product product)
        {
            var existingProduct = _context.Products.Find(product.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Description = product.Description;
                existingProduct.Price = product.Price;
                existingProduct.Quantity = product.Quantity;
                existingProduct.CategoryId = product.CategoryId;
                existingProduct.SupplierId = product.SupplierId;
                _context.SaveChanges();
                SimpleLog.WriteLog($"Cập nhật sản phẩm: {product.Name}");
            }
        }

        public void DeleteProduct(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
                SimpleLog.WriteLog($"Xóa sản phẩm: {product.Name}");
            }
        }

        public List<Product> SearchProducts(string keyword)
        {
            var products = _context.Products
                .Where(p => p.Name.Contains(keyword) || p.Description.Contains(keyword))
                .ToList();
            SimpleLog.WriteLog($"Tìm kiếm sản phẩm với từ khóa '{keyword}': tìm thấy {products.Count} sản phẩm");
            return products;
        }
    }
} 