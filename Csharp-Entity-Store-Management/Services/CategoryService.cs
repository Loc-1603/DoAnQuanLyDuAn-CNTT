using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp_Entity_Store_Management.Services
{
    public class CategoryService
    {
        private readonly StoreModelContainer _context;

        public CategoryService()
        {
            _context = new StoreModelContainer();
        }

        public List<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
            return _context.Categories.Find(id);
        }

        public void AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            var existingCategory = _context.Categories.Find(category.Id);
            if (existingCategory != null)
            {
                _context.Entry(existingCategory).CurrentValues.SetValues(category);
                _context.SaveChanges();
            }
        }

        public void DeleteCategory(int id)
        {
            var category = _context.Categories.Find(id);
            if (category != null)
            {
                // Check if category has any products
                if (_context.Products.Any(p => p.CategoryId == id))
                {
                    throw new InvalidOperationException("Cannot delete category that has products.");
                }
                _context.Categories.Remove(category);
                _context.SaveChanges();
            }
        }

        public List<Category> SearchCategories(string keyword)
        {
            return _context.Categories
                .Where(c => c.Name.Contains(keyword) || c.Description.Contains(keyword))
                .ToList();
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _context.Products
                .Where(p => p.CategoryId == categoryId)
                .ToList();
        }
    }
} 