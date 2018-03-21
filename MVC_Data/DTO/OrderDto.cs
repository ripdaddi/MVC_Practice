using System;
using System.Collections.Generic;

namespace MVC_Data.DTO
{
    public class OrderDto
    {
        public OrderDto()
        {
            OrderItems = new HashSet<OrderItemDto>();
        }

    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public string OrderNumber { get; set; }
    public int CustomerId { get; set; }
    public decimal? TotalAmount { get; set; }

    public virtual CustomerDTO Customer { get; set; }
    
    public virtual ICollection<OrderItemDto> OrderItems { get; set; }
}
}
