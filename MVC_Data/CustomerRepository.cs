using MVC_Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVC_Data
{
    public class CustomerRepository : ICustomerRepository, IDisposable
    {
        #region Constructor
        private StoreDemoWithCustomerProductEntities _context;

        public CustomerRepository(StoreDemoWithCustomerProductEntities context)
        {
            _context = context;
        }
        #endregion

        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers.ToList();
        }

        public CustomerDTO GetCutomerById(int customerId)
        {
            var customer = new CustomerDTO();
            var data = _context.Customers.Find(customerId);
            customer.City = data.City;
            customer.Phone = data.Phone;
            customer.FirstName = data.FirstName;
            customer.LastName = data.LastName;
            customer.Country = data.Country;

            // var orderList = data.Orders;
            //List<OrderDto> orderList = new List<OrderDto>();
            //foreach (var item in data.Orders)
            //{
            //    var orderDto = new OrderDto();
            //    orderDto.Id = item.Id;
            //    orderDto.OrderDate = item.OrderDate;
            //    orderDto.OrderNumber = items.
            //}
            //customer.Orders
            return customer;
        }
        //public void InsertCustomer(Customer customer)
        //{
        //    _context.Customers.Add(customer);
        //}

        //public void DeleteCustomer (int customerId)
        //{
        //    Customer customer = _context.Customers.Find(customerId);
        //    _context.Customers.Remove(customer);
        //}
        //public void UpdateCustomer(Customer customer)
        //{
        //    _context.Entry(customer).State = System.Data.Entity.EntityState.Modified;
        //}

        //public void Save()
        //{
        //    _context.SaveChanges();
        //}



        #region Dispose
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        #endregion
    }
}
