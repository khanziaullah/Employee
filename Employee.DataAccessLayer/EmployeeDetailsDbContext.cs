using Employee.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.DataAccessLayer
{
    class EmployeeDetailsDbContext
    {
        public bool SaveEmployeeDetail(EmployeeDTO employee)
        {
            return true;
        }

        public EmployeeDTO GetEmployeeDetail(int employeeId)
        {
            return new EmployeeDTO
            {
                FirstName = "Ziaullah",
                LastName = "Khan",
                Address = "Mumbai"
            };
        }
    }
}
