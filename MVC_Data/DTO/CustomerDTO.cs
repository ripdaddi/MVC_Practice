using System.Collections.Generic;


namespace MVC_Data.DTO
{
   public class CustomerDTO
    {
        public CustomerDTO()
        {
            Orders = new List<OrderDto>();
        }
        public StoreDemoWithCustomerProductEntities _db;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }

        
        public virtual ICollection<OrderDto> Orders { get; set; }
        public CustomerDTO GetCustomer(Customer customer)
        {
            var customerDto = new CustomerDTO();
            if (customer.Id != 0)
            {
                customerDto.Id = customer.Id;
            }            
            customerDto.FirstName = customer.FirstName;
            customerDto.LastName = customer.LastName;
            customerDto.Phone = customer.Phone;
            //customerDto.Orders = customer.Orders

            foreach (var item in customer.Orders)
            {
                //customerDto.Orders.Add(item);
            }  
           // customerOrders = new

           // customerDto.Orders = customer.Orders;

            return customerDto;


        }

        //List<CustomerDTO> customerDTO =  new List<CustomerDTO>(from c in Customer
        //                                 select new CustomerDTO()
        //                                 {
        //                                     Id = c.Id,
        //                                     ContactName = c.Contact,
        //                                     PhoneNo = c.Phone
        //                                 }).ToList();
        //private  CustomerDTO TranslateToEntity()
        //{
        //    CustomerDTO customerDto = new CustomerDTO();
        //    this.Id = customer.Id;
        //    this.FirstName = customer.FirstName;
        //    this.City = customer.City;
        //    this.Country = customer.Country;
        //    this.Phone = customer.Phone;

        //    return customerDto;


        // DTO class
        //public class MyDTO
        //{
        //    public string CompanyName { get; set; }
        //    public string ContactName { get; set; }
        //    public string PhoneNo { get; set; }
        //}


        //}
    }
}
