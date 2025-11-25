using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp_Entity_Store_Management.Services
{
    public class ProductService
    {
        private readonly StoreModelContainer _context;

        public ProductService()
        {
            _context = new StoreModelContainer();
        }

        public List<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public Product GetProductById(int id)
        {
            return _context.Products.Find(id);
        }

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            var existingProduct = _context.Products.Find(product.Id);
            if (existingProduct != null)
            {
                _context.Entry(existingProduct).CurrentValues.SetValues(product);
                _context.SaveChanges();
            }
        }

        public void DeleteProduct(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }

        public List<Product> SearchProducts(string keyword)
        {
            return _context.Products
                .Where(p => p.Name.Contains(keyword) || p.Description.Contains(keyword))
                .ToList();
        }
    }
} 