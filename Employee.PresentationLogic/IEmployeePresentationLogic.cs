using Employee.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee.PresentationLogic
{
	public interface IEmployeePresentationLogic
	{
		bool SaveEmployeeDetail(EmployeeVM employee);
		EmployeeVM GetEmployeeDetail(int employeeId);
		bool DeleteEmployee(int employeeId);
	}
}
