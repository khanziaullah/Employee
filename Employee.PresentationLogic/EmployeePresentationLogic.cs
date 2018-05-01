using Employee.PresentationLogic.EmployeeDetailsServiceReference;
using Employee.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.PresentationLogic
{
    public class EmployeePresentationLogic : IEmployeePresentationLogic
    {
		EmployeeDetailsServiceClient client;

		public EmployeePresentationLogic(EmployeeDetailsServiceClient client)
		{
			this.client = client;
		}

        public EmployeeVM GetEmployeeDetail(int employeeId)
        {
            var request = new GetEmployeeDetailsRequest
            {
                EmployeeId = employeeId
            };

            var response = client.GetEmployeeDetails(request);

            return new EmployeeVM
            {
                FirstName = response.FirstName,
                LastName = response.LastName,
                Address = response.Address,
            };
        }

		public bool SaveEmployeeDetail(EmployeeVM employee)
		{
			throw new NotImplementedException();
		}

		public bool DeleteEmployee(int employeeId)
        {
			throw new NotImplementedException();
		}
	}
}
