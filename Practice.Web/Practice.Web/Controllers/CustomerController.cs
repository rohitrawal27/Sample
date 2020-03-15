using Practice.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice.Web.Controllers
{
    public class CustomerController : Controller
    {
        ICustomersService customerService;

        public CustomerController() : this(new CustomersService())
        {
        }

        public CustomerController(ICustomersService customerService)
        {
            this.customerService = customerService;
        }
        // GET: Customer
        public ActionResult Index()
        {
            var customers = this.customerService.GetCustomers();
            return View(customers);
        }
    }
}