using Employee.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.DataAccessLayer;

namespace Employee.BusinessLogicLayer
{
    public class EmployeeDetails : IEmployeeDetails
    {
        DataAccessLayer.IEmployeeDetails employeeDetails;

        public EmployeeDetails(DataAccessLayer.IEmployeeDetails employeeDetails)
        {
            this.employeeDetails = employeeDetails;
        }

        public bool SaveEmployeeDetail(EmployeeDTO employee)
        {
            return employeeDetails.SaveEmployeeDetail(employee);
        }

        public EmployeeDTO GetEmployeeDetail(int employeeId)
        {
            return employeeDetails.GetEmployeeDetail(employeeId);
        }
    }
}
