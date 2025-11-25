using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp_Entity_Store_Management.Business
{
    public class CustomerBusiness
    {
        private readonly StoreModelContainer _context;

        public CustomerBusiness()
        {
            _context = new StoreModelContainer();
        }

        public List<Customer> GetAllCustomers()
        {
            var customers = _context.Customers.ToList();
            SimpleLog.WriteLog($"Lấy danh sách khách hàng: {customers.Count} khách hàng");
            return customers;
        }

        public void AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            SimpleLog.WriteLog($"Thêm khách hàng mới: {customer.Name}");
        }

        public void UpdateCustomer(Customer customer)
        {
            var existingCustomer = _context.Customers.Find(customer.Id);
            if (existingCustomer != null)
            {
                existingCustomer.Name = customer.Name;
                existingCustomer.Phone = customer.Phone;
                existingCustomer.Email = customer.Email;
                existingCustomer.Address = customer.Address;
                _context.SaveChanges();
                SimpleLog.WriteLog($"Cập nhật thông tin khách hàng: {customer.Name}");
            }
        }

        public void DeleteCustomer(int id)
        {
            var customer = _context.Customers.Find(id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
                SimpleLog.WriteLog($"Xóa khách hàng: {customer.Name}");
            }
        }

        public List<Customer> SearchCustomers(string keyword)
        {
            var customers = _context.Customers
                .Where(c => c.Name.Contains(keyword) || 
                           c.Phone.Contains(keyword) || 
                           c.Email.Contains(keyword) ||
                           c.Address.Contains(keyword))
                .ToList();
            SimpleLog.WriteLog($"Tìm kiếm khách hàng với từ khóa '{keyword}': tìm thấy {customers.Count} khách hàng");
            return customers;
        }
    }
} 