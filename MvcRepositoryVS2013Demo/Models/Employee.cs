using System.ComponentModel.DataAnnotations;

namespace MvcRepositoryVS2013Demo.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Display(Name="First Name")]
        public string FirstName { get; set; }
        [Display(Name="Last Name")]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}