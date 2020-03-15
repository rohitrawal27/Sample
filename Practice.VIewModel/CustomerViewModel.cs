
using Practice.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practice.ViewModel
{
    public class CustomerViewModel
    {
        [Key]
        public Guid CustomerID { get; set; }

        public string CustomerName { get; set; }

        public string CountryIso3 { get; set; }

        public string RegionCode { get; set; }
    }
}