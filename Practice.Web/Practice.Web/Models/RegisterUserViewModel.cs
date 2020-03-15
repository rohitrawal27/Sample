using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice.Web.Models
{
    public class RegisterUserViewModel: RegisterViewModel
    {
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
    }
}