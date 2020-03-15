using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Practice.Web.Models;
using Practice.Web.Repository;
using Practice.Web.ViewModel;

namespace Practice.Web.Service
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

        public List<CustomerViewModel> GetCustomers()
        {
            List<Customer> customer = customerRepository.GetCustomers();
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<Question, QuestionViewModel>(); cfg.IgnoreUnmapped(); });
            IMapper mapper = config.CreateMapper();
            List<QuestionViewModel> qvm = mapper.Map<List<Question>, List<QuestionViewModel>>(q);
            return qvm;
        }

        public void InsertCustomers(NewCustomerViewModel customerViewModel)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<NewQuestionViewModel, Question>(); cfg.IgnoreUnmapped(); });
            IMapper mapper = config.CreateMapper();
            Question q = mapper.Map<NewQuestionViewModel, Question>(qvm);
            qr.InsertQuestion(q);
        }

        public void UpdateCustomer(EditCustomerViewModel customerViewModel)
        {
            throw new NotImplementedException();
        }
    }
}