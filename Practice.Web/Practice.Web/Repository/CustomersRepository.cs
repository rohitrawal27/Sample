using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Practice.Web.Models;

namespace Practice.Web.Repository
{
    public class CustomersRepository : ICustomerRepository
    {
        ApplicationDbContext dbContext;

        public CustomersRepository()
        {
            dbContext = new ApplicationDbContext();
        }

        public void DeleteCustomer(int customerId)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetCustomers()
        {
            List<Customer> customers = dbContext.customers.OrderByDescending(temp => temp.CustomerID).ToList();
            return customers;
        }

        public void InsertCustomer(Customer customer)
        {
            dbContext.customers.Add(customer);
            dbContext.SaveChanges();
        }

        public void UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}