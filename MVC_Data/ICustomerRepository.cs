using MVC_Data.DTO;
using System;
using System.Collections.Generic;

namespace MVC_Data
{
    public interface ICustomerRepository : IDisposable
    {
        IEnumerable<Customer> GetCustomers();
        CustomerDTO GetCutomerById(int cutomerId);
        //void InsertCustomer(Customer customer);
        //void DeleteCustomer(int customerId);
        //void UpdateCustomer(Customer customer);
        //void Save();
    }
}
