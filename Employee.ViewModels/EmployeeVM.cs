using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.ViewModels
{
    public class EmployeeVM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + LastName; } }
        public string Address { get; set; }
        public bool Success { get; set; }
    }
}
