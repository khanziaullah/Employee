using Employee.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.DataAccessLayer;

namespace Employee.DataAccessLayer
{
    public class EmployeeDetails : IEmployeeDetails
    {
        EmployeeDetailsDbContext dbContext = new EmployeeDetailsDbContext();

        public EmployeeDetails()
        {
        }

        public bool SaveEmployeeDetail(EmployeeDTO employee)
        {
            return dbContext.SaveEmployeeDetail(employee);
        }

        public EmployeeDTO GetEmployeeDetail(int employeeId)
        {
            return dbContext.GetEmployeeDetail(employeeId);
        }
    }
}
