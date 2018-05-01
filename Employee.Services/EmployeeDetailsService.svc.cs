using Employee.BusinessLogicLayer;
using Employee.Services.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Employee.Model;

namespace Employee.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeDetailsService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployeeDetailsService.svc or EmployeeDetailsService.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeDetailsService : IEmployeeDetailsService
    {
        IEmployeeDetails employeeDetails;

        public EmployeeDetailsService(IEmployeeDetails employeeDetails)
        {
            this.employeeDetails = employeeDetails;
        }

        public GetEmployeeDetailsResponse GetEmployeeDetails(GetEmployeeDetailsRequest request)
        {
            var employee = employeeDetails.GetEmployeeDetail(request.EmployeeId);

            return new GetEmployeeDetailsResponse
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Address = employee.Address,
            };
        }
    }
}
