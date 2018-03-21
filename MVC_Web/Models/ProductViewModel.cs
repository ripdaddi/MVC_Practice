using MVC_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Web.Models
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
            this.OrderItems = new HashSet<OrderItemViewModel>();
        }

        public int Id { get; set; }
        public string ProductName { get; set; }
        public int SupplierId { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public string Package { get; set; }
        public bool IsDiscontinued { get; set; }


        public virtual ICollection<OrderItemViewModel> OrderItems { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }
        public virtual SupplierViewModel Supplier
        {
            get; set;

        }
    }
}