﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Web.Models
{
    public class SupplierViewModel
    {
        public SupplierViewModel()
        {
            Products = new HashSet<ProductViewModel>();
        }

        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

        
        public virtual ICollection<ProductViewModel> Products { get; set; }

    }
}