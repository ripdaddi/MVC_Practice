using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Web.Models
{
    public class OrderItemViewModel
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }

        public virtual OrderViewModel Order { get; set; }
        public virtual ProductViewModel Product { get; set; }
    }
}