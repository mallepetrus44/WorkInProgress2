using System;
using System.ComponentModel.DataAnnotations;

namespace WorkInProgress2.Shared.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Display(Name = "Naam Klant")]
        public string Name { get; set; }

        [Display(Name = "Klantdetails")]
        public string Detail { get; set; }

        [Display(Name = "Registratiedatum")]
        [DataType(DataType.Date)]
        public DateTime RegisterDate { get; internal set; }

        public string EmployeeId { get; set; }

        public ProductList ProductList { get; set; }


    }
}
