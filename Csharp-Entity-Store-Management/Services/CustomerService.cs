using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp_Entity_Store_Management.Services
{
    public class CustomerService
    {
        private readonly StoreModelContainer _context;

        public CustomerService()
        {
            _context = new StoreModelContainer();
        }

        public List<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }

        public Customer GetCustomerById(int id)
        {
            return _context.Customers.Find(id);
        }

        public void AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void UpdateCustomer(Customer customer)
        {
            var existingCustomer = _context.Customers.Find(customer.Id);
            if (existingCustomer != null)
            {
                _context.Entry(existingCustomer).CurrentValues.SetValues(customer);
                _context.SaveChanges();
            }
        }

        public void DeleteCustomer(int id)
        {
            var customer = _context.Customers.Find(id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }
        }

        public List<Customer> SearchCustomers(string keyword)
        {
            return _context.Customers
                .Where(c => c.Name.Contains(keyword) || 
                           c.Phone.Contains(keyword) || 
                           c.Email.Contains(keyword))
                .ToList();
        }
    }
} 