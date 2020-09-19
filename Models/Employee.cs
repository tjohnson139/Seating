using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seating.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get; set; }
        public bool NotActive { get; set; }
        public int Force { get; set; }
    }
}