using Employee.ViewModels;
using Employee.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.PresentationLogic;

namespace Employee.Presenter
{
    public class EmployeePresenter : IEmployeePresenter
	{
        IEmployeeView view;
        IEmployeePresentationLogic presentationLogic;

        public EmployeePresenter(IEmployeeView view, IEmployeePresentationLogic presentationLogic)
        {
			this.view = view;
            this.presentationLogic = presentationLogic;
        }

        public void GetEmployeeDetails(int employeeId)
        {
            var employeeVM = presentationLogic.GetEmployeeDetail(employeeId);

            view.FirstName = employeeVM.FirstName;
            view.LastName = employeeVM.LastName;
            view.Address = employeeVM.Address;
        }

        public bool SaveEmployeeDetail()
        {
			throw new NotImplementedException();
		}
    }
}
