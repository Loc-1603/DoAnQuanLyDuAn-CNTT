using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp_Entity_Store_Management.Services
{
    public class StockInService
    {
        private readonly StoreModelContainer _context;

        public StockInService()
        {
            _context = new StoreModelContainer();
        }

        public List<StockIn> GetAllStockIns()
        {
            return _context.StockIns.ToList();
        }

        public StockIn GetStockInById(int id)
        {
            return _context.StockIns.Find(id);
        }

        public void AddStockIn(StockIn stockIn)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    _context.StockIns.Add(stockIn);
                    _context.SaveChanges();

                    // Update product quantity
                    var product = _context.Products.Find(stockIn.ProductId);
                    if (product != null)
                    {
                        product.Quantity += stockIn.Quantity;
                    }

                    _context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public List<StockIn> GetStockInsByDateRange(DateTime startDate, DateTime endDate)
        {
            return _context.StockIns
                .Where(s => s.Date >= startDate && s.Date <= endDate)
                .ToList();
        }

        public List<StockIn> GetStockInsByProduct(int productId)
        {
            return _context.StockIns
                .Where(s => s.ProductId == productId)
                .ToList();
        }

        public List<StockIn> GetStockInsBySupplier(int supplierId)
        {
            return _context.StockIns
                .Where(s => s.SupplierId == supplierId)
                .ToList();
        }
    }
} 