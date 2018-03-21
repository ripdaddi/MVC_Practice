using MVC_Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Data
{
    public class OrderRepository
    {

        private StoreDemoWithCustomerProductEntities _context;
        public OrderRepository(StoreDemoWithCustomerProductEntities context)
        {
            this._context = context;
        }


        public IEnumerable<Order> GetAllOrders()
        {
            return _context.Orders.ToList();
        }

        public IEnumerable<OrderDto> GetOrdersByCustomerId(int customerId)
        {

            var customerOrders = from customers in _context.Customers
                                 join orders in _context.Orders 
                                 on customers.Id 
                                 equals orders.CustomerId
                                 where customers.Id == customerId
                                 select orders;
            var orderList = new List<OrderDto>();
            var itemList = new List<OrderItemDto>();
            var productList = new List<ProductDto>();
            var orderDto = new OrderDto();
            foreach (var item in customerOrders)
            {
                var customer = new CustomerDTO
                {
                    City = item.Customer.City,
                    Country = item.Customer.Country,
                    FirstName = item.Customer.FirstName,
                    LastName = item.Customer.LastName,
                    Phone = item.Customer.Phone

                };
                
                orderDto.OrderDate = item.OrderDate;
                orderDto.OrderNumber = item.OrderNumber;
                orderDto.TotalAmount = item.TotalAmount;

                orderList.Add(orderDto);
                foreach (var prd in item.OrderItems)
                {
                    var orderItem = new OrderItemDto();
                    orderItem.OrderId = prd.OrderId;
                    orderItem.ProductId = prd.ProductId;
                    orderItem.Quantity = prd.Quantity;
                    orderItem.UnitPrice = prd.UnitPrice;

                    var product = new ProductDto();
                    product.Id = prd.Product.Id;
                    product.IsDiscontinued = prd.Product.IsDiscontinued;
                    product.Package = prd.Product.Package;
                    product.ProductName = prd.Product.ProductName;

                    productList.Add(product);
                }
            }
            
            //select new OrderDto
            //{
            //    Customer =
            //        new CustomerDTO
            //        {
            //            FirstName = customers.FirstName,
            //            LastName = customers.LastName,
            //            Phone = customers.Phone,
            //            City = customers.City,
            //            Country = customers.Country,
            //            Id = customers.Id
            //        }
            //};

            //var orderDto = customerOrders;
            return orderList;
       }
    }
}
