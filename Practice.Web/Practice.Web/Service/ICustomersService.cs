using Practice.Web.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Web.Service
{
  public  interface ICustomersService
    {
        void InsertCustomers(NewCustomerViewModel customerViewModel);
        void UpdateCustomer(EditCustomerViewModel customerViewModel);
        void DeleteCustomer(int customerId);
        List<CustomerViewModel> GetCustomers();
    }
}
