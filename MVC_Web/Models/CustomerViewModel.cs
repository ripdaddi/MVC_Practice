using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC_Web.Models
{
    public class CustomerViewModel
    {
        public CustomerViewModel()
        {
            Orders = new HashSet<OrderViewModel>();
        }

        public int Id { get; set; } 

        [Required(ErrorMessage ="First Name is required")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "City is required")]
        [DisplayName("City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Country is required")]
        [DisplayName("Country")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        [DisplayName("Phone Number")]
        public string Phone { get; set; }

       
        public virtual ICollection<OrderViewModel> Orders { get; set; }
    }
}