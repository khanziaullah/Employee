namespace Employee.Presenter
{
	public interface IEmployeePresenter
	{
		void GetEmployeeDetails(int employeeId);
		bool SaveEmployeeDetail();
	}
}