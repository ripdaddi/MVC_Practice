﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Data.DTO
{
   public class SupplierDto
    { 
    public SupplierDto()
    {
            Products = new HashSet<ProductDto>();
    }

    public int Id { get; set; }
    public string CompanyName { get; set; }
    public string ContactName { get; set; }
    public string ContactTitle { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string Phone { get; set; }
    public string Fax { get; set; }

   
    public virtual ICollection<ProductDto> Products { get; set; }
}
}
