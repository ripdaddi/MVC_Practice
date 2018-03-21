using System;
using System.Collections.Generic;

namespace MVC_Data.DTO
{
    public class ProductDto
    {
        public ProductDto()
        {
            this.OrderItems = new HashSet<OrderItemDto>();
        }

        public int Id { get; set; }
        public string ProductName { get; set; }
        public int SupplierId { get; set; }
        public decimal? UnitPrice { get; set; }
        public string Package { get; set; }
        public bool IsDiscontinued { get; set; }

      
        public virtual ICollection<OrderItemDto> OrderItems { get; set; }
        public virtual SupplierDto Supplier { get; set; }
    }
}

