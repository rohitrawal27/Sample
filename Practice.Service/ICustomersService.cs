using Practice.Entities;
using Practice.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Service
{
  public  interface ICustomersService
    {
        //void InsertCustomers(NewCustomerViewModel customerViewModel);
        //void UpdateCustomer(EditCustomerViewModel customerViewModel);
        //void DeleteCustomer(int customerId);
        List<Customer> GetCustomers();

        //void InsertCustomers(NewCustomerViewModel customerViewModel);
        //void UpdateCustomer(EditCustomerViewModel customerViewModel);
        //void DeleteCustomer(int customerId);
        //List<CustomerViewModel> GetCustomers();
    }
}
