using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Practice.Entities;
using Practice.Repository;
using Practice.ViewModel;

namespace Practice.Service
{
    public class CustomersService : ICustomersService
    {
        ICustomerRepository customerRepository;

        public CustomersService()
        {
            customerRepository = new CustomersRepository();
        }
        public void DeleteCustomer(int customerId)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetCustomers()
        {
            List<Customer> customer = customerRepository.GetCustomers();
            //var config = new MapperConfiguration(cfg => { cfg.CreateMap<Customer, CustomerViewModel>(); cfg.IgnoreUnmapped(); });
            //IMapper mapper = config.CreateMapper();
            //List<CustomerViewModel> customerViewModel = mapper.Map<List<Customer>, List<CustomerViewModel>>(customer);
            return customer;
        }

        //public List<CustomerViewModel> GetCustomers()
        //{
        //    List<Customer> customer = customerRepository.GetCustomers();
        //    var config = new MapperConfiguration(cfg => { cfg.CreateMap<Customer, CustomerViewModel>(); cfg.IgnoreUnmapped(); });
        //    IMapper mapper = config.CreateMapper();
        //    List<CustomerViewModel> customerViewModel = mapper.Map<List<Customer>, List<CustomerViewModel>>(customer);
        //    return customerViewModel;
        //}

        //public void InsertCustomers(NewCustomerViewModel customerViewModel)
        //{
        //    var config = new MapperConfiguration(cfg => { cfg.CreateMap<NewCustomerViewModel, Customer>(); cfg.IgnoreUnmapped(); });
        //    IMapper mapper = config.CreateMapper();
        //    Customer customer = mapper.Map<NewCustomerViewModel, Customer>(customerViewModel);
        //    customerRepository.InsertCustomer(customer);
        //}

        //public void UpdateCustomer(EditCustomerViewModel customerViewModel)
        //{
        //    throw new NotImplementedException();
        //}
    }
}