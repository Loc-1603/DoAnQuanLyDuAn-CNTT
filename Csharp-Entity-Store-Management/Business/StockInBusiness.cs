using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp_Entity_Store_Management.Business
{
    public class StockInBusiness
    {
        private readonly StoreModelContainer _context;

        public StockInBusiness()
        {
            _context = new StoreModelContainer();
        }

        public List<StockIn> GetAllStockIns()
        {
            var stockIns = _context.StockIns.ToList();
            SimpleLog.WriteLog($"Lấy danh sách nhập kho: {stockIns.Count} lần nhập");
            return stockIns;
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
                    SimpleLog.WriteLog($"Nhập kho sản phẩm ID {stockIn.ProductId}: {stockIn.Quantity} sản phẩm");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    SimpleLog.WriteLog($"Lỗi khi nhập kho: {ex.Message}");
                    throw;
                }
            }
        }

        public List<StockIn> GetStockInsByDateRange(DateTime startDate, DateTime endDate)
        {
            var stockIns = _context.StockIns
                .Where(s => s.Date >= startDate && s.Date <= endDate)
                .ToList();
            SimpleLog.WriteLog($"Lấy lịch sử nhập kho từ {startDate:dd/MM/yyyy} đến {endDate:dd/MM/yyyy}: {stockIns.Count} lần nhập");
            return stockIns;
        }

        public List<StockIn> GetStockInsByProduct(int productId)
        {
            var stockIns = _context.StockIns
                .Where(s => s.ProductId == productId)
                .ToList();
            SimpleLog.WriteLog($"Lấy lịch sử nhập kho sản phẩm ID {productId}: {stockIns.Count} lần nhập");
            return stockIns;
        }
    }
} 