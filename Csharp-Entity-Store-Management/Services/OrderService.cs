using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp_Entity_Store_Management.Services
{
    public class OrderService
    {
        private readonly StoreModelContainer _context;

        public OrderService()
        {
            _context = new StoreModelContainer();
        }

        public List<Order> GetAllOrders()
        {
            return _context.Orders.ToList();
        }

        public Order GetOrderById(int id)
        {
            return _context.Orders.Find(id);
        }

        public void CreateOrder(Order order, List<OrderDetail> orderDetails)
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
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public List<Order> GetOrdersByCustomerId(int customerId)
        {
            return _context.Orders
                .Where(o => o.CustomerId == customerId)
                .ToList();
        }

        public List<Order> GetOrdersByDateRange(DateTime startDate, DateTime endDate)
        {
            return _context.Orders
                .Where(o => o.OrderDate >= startDate && o.OrderDate <= endDate)
                .ToList();
        }
    }
} 