using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp_Entity_Store_Management.Business
{
    public class OrderBusiness
    {
        private readonly StoreModelContainer _context;

        public OrderBusiness()
        {
            _context = new StoreModelContainer();
        }

        public List<Order> GetAllOrders()
        {
            var orders = _context.Orders.ToList();
            SimpleLog.WriteLog($"Lấy danh sách đơn hàng: {orders.Count} đơn hàng");
            return orders;
        }

        public void AddOrder(Order order, List<OrderDetail> orderDetails)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    _context.Orders.Add(order);
                    _context.SaveChanges();

                    foreach (var detail in orderDetails)
                    {
                        detail.OrderId = order.Id;
                        _context.OrderDetails.Add(detail);

                        // Update product quantity
                        var product = _context.Products.Find(detail.ProductId);
                        if (product != null)
                        {
                            product.Quantity -= detail.Quantity;
                        }
                    }

                    _context.SaveChanges();
                    transaction.Commit();
                    SimpleLog.WriteLog($"Tạo đơn hàng mới: Đơn hàng #{order.Id} - Tổng tiền: {order.TotalAmount}");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    SimpleLog.WriteLog($"Lỗi khi tạo đơn hàng: {ex.Message}");
                    throw;
                }
            }
        }

        public List<Order> GetOrdersByCustomer(int customerId)
        {
            var orders = _context.Orders
                .Where(o => o.CustomerId == customerId)
                .ToList();
            SimpleLog.WriteLog($"Lấy đơn hàng của khách hàng ID {customerId}: {orders.Count} đơn hàng");
            return orders;
        }

        public List<Order> GetOrdersByDateRange(DateTime startDate, DateTime endDate)
        {
            var orders = _context.Orders
                .Where(o => o.OrderDate >= startDate && o.OrderDate <= endDate)
                .ToList();
            SimpleLog.WriteLog($"Lấy đơn hàng từ {startDate:dd/MM/yyyy} đến {endDate:dd/MM/yyyy}: {orders.Count} đơn hàng");
            return orders;
        }

        public List<OrderDetail> GetOrderDetails(int orderId)
        {
            var details = _context.OrderDetails
                .Where(od => od.OrderId == orderId)
                .ToList();
            SimpleLog.WriteLog($"Lấy chi tiết đơn hàng #{orderId}: {details.Count} sản phẩm");
            return details;
        }
    }
} 