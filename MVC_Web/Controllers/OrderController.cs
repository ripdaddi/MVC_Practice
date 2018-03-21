using MVC_Data;
using MVC_Web.Models;
using System.Web.Mvc;

using System.Collections.Generic;
using MVC_Data.DTO;

namespace MVC_Web.Controllers
{
    public class OrderController : Controller
    {

        //private ICustomerRepository ;

        private OrderRepository _orderRepository;
        public OrderController()
        {
            this._orderRepository = new OrderRepository(new StoreDemoWithCustomerProductEntities());
        }

        public OrderController(OrderRepository customerRepository)
        {
            this._orderRepository = customerRepository;
        }


        // GET: Order
        public ActionResult Index()
        {
            // var orders = 
            var orderViewModel = new OrderViewModel();
            var dataList = _orderRepository.GetOrdersByCustomerId(2);
            //setting up customer
            var customer = new CustomerViewModel();
            using (var context = new StoreDemoWithCustomerProductEntities())
            {
                var customerData = context.Customers.Find(2);
                //customer info
                customer.City = customerData.City;
                customer.Country = customerData.Country;
                customer.FirstName = customerData.FirstName;
                customer.LastName = customerData.LastName;
                customer.Phone = customerData.Phone;
                customer.Id = 2;
            }
            //setting up order Items
            orderViewModel.OrderItems = new List<OrderItemViewModel>();
            if (customer.Orders.Count > 0)
            {
                foreach (var orderItem in orderViewModel.OrderItems)
                {
                    var orderItemListItem = new OrderItemViewModel();
                    orderItemListItem.Id = orderItem.Id;
                    orderItemListItem.OrderId = orderItem.OrderId;
                    orderItemListItem.ProductId = orderItem.ProductId;
                    orderItemListItem.UnitPrice = orderItem.UnitPrice;

                    //add order item to orderItemList
                    orderViewModel.OrderItems.Add(orderItemListItem);
                }
            }
         
            //intialized customer & fill with data
            var orderVM = new OrderViewModel();
            orderVM.Customer = customer;

            //fill order list
            foreach (var item in dataList)
            {
                var order = new OrderViewModel();
                order.Customer = customer;
                order.Id = item.Id;
                order.OrderDate = item.OrderDate;
                order.OrderNumber = item.OrderNumber;
                order.TotalAmount = item.TotalAmount;

                //add orders to list
                //orderList.Add(order);
                //order items list
               // var itemList = new List<OrderItemViewModel>();
                //var orderItems = new OrderItemViewModel();
                //foreach (var products in item.OrderItems)
                //{
                //    orderItems.Id = products.Id;
                //    orderItems.OrderId = products.OrderId;
                //    orderItems.ProductId = products.ProductId;
                //    orderItems.Quantity = products.Quantity;
                //    orderItems.UnitPrice = products.UnitPrice;


                //    itemList.Add(orderItems);
                   // orderItems.Product = new ProductViewModel();
                   
                }

            return View(orderViewModel);
        }


        public ActionResult GetOrdersByCustomerId(int customerId)
        {
            var viewModel = new OrderViewModel();
           // viewModel.OrderItems = _re



            return View();
        }
    }
}