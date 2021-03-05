using System.Collections.Generic;
using WorkInProgress2.Shared.Models.Enums;

namespace WorkInProgress2.Shared.Models
{
    public class Employee : ApplicationUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Departments Department { get; set; }
        public EmployeeSorts EmployeeSort { get; set; }
        public AccountType AccountType { get; set; }
        public List<Customer> EmployeeCustomerList { get; set; }
    }
}
