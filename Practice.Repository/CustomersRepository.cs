using Practice.Entities;
using Practice.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Practice.Repository
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
            var customers = dbContext.customers.OrderByDescending(temp => temp.CustomerID).ToList();
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