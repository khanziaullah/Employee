using Employee.Model;

namespace Employee.BusinessLogicLayer
{
    public interface IEmployeeDetails
    {
        EmployeeDTO GetEmployeeDetail(int employeeId);
        bool SaveEmployeeDetail(EmployeeDTO employee);
    }
}