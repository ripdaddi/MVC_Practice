using System;
using System.Collections.Generic;

namespace MVC_Web.Models
{
    public class OrderViewModel
    {
        
        public OrderViewModel()
        {
            this.OrderItems = new HashSet<OrderItemViewModel>();
        }

        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderNumber { get; set; }
        public int CustomerId { get; set; }
        public decimal? TotalAmount { get; set; }

        public virtual CustomerViewModel Customer { get; set; }
       
        public virtual ICollection<OrderItemViewModel> OrderItems { get; set; }
    }
}