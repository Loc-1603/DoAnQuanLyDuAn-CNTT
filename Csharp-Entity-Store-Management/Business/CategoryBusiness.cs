using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp_Entity_Store_Management.Business
{
    public class CategoryBusiness
    {
        private readonly StoreModelContainer _context;

        public CategoryBusiness()
        {
            _context = new StoreModelContainer();
        }

        public List<Category> GetAllCategories()
        {
            var categories = _context.Categories.ToList();
            SimpleLog.WriteLog($"Lấy danh sách danh mục: {categories.Count} danh mục");
            return categories;
        }

        public void AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            SimpleLog.WriteLog($"Thêm danh mục mới: {category.Name}");
        }

        public void UpdateCategory(Category category)
        {
            var existingCategory = _context.Categories.Find(category.Id);
            if (existingCategory != null)
            {
                existingCategory.Name = category.Name;
                existingCategory.Description = category.Description;
                _context.SaveChanges();
                SimpleLog.WriteLog($"Cập nhật danh mục: {category.Name}");
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
                    SimpleLog.WriteLog($"Không thể xóa danh mục {category.Name} vì còn sản phẩm");
                    throw new InvalidOperationException("Cannot delete category that has products.");
                }
                _context.Categories.Remove(category);
                _context.SaveChanges();
                SimpleLog.WriteLog($"Xóa danh mục: {category.Name}");
            }
        }

        public List<Category> SearchCategories(string keyword)
        {
            var categories = _context.Categories
                .Where(c => c.Name.Contains(keyword) || c.Description.Contains(keyword))
                .ToList();
            SimpleLog.WriteLog($"Tìm kiếm danh mục với từ khóa '{keyword}': tìm thấy {categories.Count} danh mục");
            return categories;
        }
    }
} 