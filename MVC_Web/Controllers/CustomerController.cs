using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_Data;
using System.Web.Mvc;
using MVC_Web.Models;

namespace MVC_Web.Controllers
{
    public class CustomerController : Controller
    {
        
        private readonly ICustomerRepository _customerRepository;
        public CustomerController()
        {
            _customerRepository = new CustomerRepository(new StoreDemoWithCustomerProductEntities());

        }

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        // GET: Customer
        //public ViewResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        //{
        //    ViewBag.CurrentSort = sortOrder;
        //    ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
        //    ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";

        //    if (searchString != null)
        //    {
        //        page = 1;
        //    }
        //    else
        //    {
        //        searchString = currentFilter;
        //    }
        //    ViewBag.CurrentFilter = searchString;

        //    var customers = from s in _customerRepository.GetCustomers()
        //                   select s;
        //    if (!String.IsNullOrEmpty(searchString))
        //    {
        //        customers = customers.Where(s => s.LastName.ToUpper().Contains(searchString.ToUpper())
        //                               || s.FirstName.ToUpper().Contains(searchString.ToUpper()));
        //    }
        //    switch (sortOrder)
        //    {
        //        case "name_desc":
        //            customers = customers.OrderByDescending(s => s.LastName);
        //            break;
        //        //case "Date":
        //        //    customers = customers.OrderBy(s => s.Phone);
        //        //    break;
        //        //case "date_desc":
        //        //    customers = customers.OrderByDescending(s => s.EnrollmentDate);
        //        //    break;
        //        default:  // Name ascending 
        //            customers = customers.OrderBy(s => s.LastName);
        //            break;
        //    }

        //    int pageSize = 3;
        //    int pageNumber = (page ?? 1);
        //    return View(customers);
        //}
        public ActionResult Index()
        {
            var viewModel = new CustomerViewModel();

            return View(viewModel);


        }

        public ActionResult Create()
        {
            var viewModel = new CustomerViewModel();
            return View();
        }

        [HttpPost]
        public ActionResult CreateCustomer(CustomerViewModel customer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var _db = new StoreDemoWithCustomerProductEntities())
                    {
                        var newCustomer = new Customer()
                        {
                            City = customer.City,
                            Country = customer.Country,
                            FirstName = customer.FirstName,
                            LastName = customer.LastName,
                            Phone = customer.Phone
                        };
                        _db.Customers.Add(newCustomer);
                        _db.SaveChanges();
                        // _customerRepository.Save();
                    }
                    //..customer.City = 

                   // _customerRepository.InsertCustomer(customer);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return View("ListCustomers");
        }

        public ActionResult ListCustomers()
        {
            var customerList = new List<CustomerViewModel>();
            var dataList = _customerRepository.GetCustomers().ToList();
           
            foreach (var item in dataList)
            {
                var viewModel = new CustomerViewModel();
                viewModel.City = item.City;
                viewModel.Country = item.Country;
                viewModel.FirstName = item.FirstName;
                viewModel.LastName = item.LastName;
                viewModel.Phone = item.Phone;

                customerList.Add(viewModel);
            }
            
            return View(customerList.ToList());
        }

        public ActionResult GetOrdersByCustomerId(int customerId)
        {
            var orderViewModel = new OrderViewModel();

            //using (var _db = new StoreDemoWithCustomerProductEntities())
            //{
            //    var order = _db.Orders.Where(a => a.CustomerId == customerId);

            //   orderViewModel.OrderItems = 
            //}


            return View(orderViewModel);
           
        }
    }
}