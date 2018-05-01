using Employee.Model;

namespace Employee.DataAccessLayer
{
    public interface IEmployeeDetails
    {
        EmployeeDTO GetEmployeeDetail(int employeeId);
        bool SaveEmployeeDetail(EmployeeDTO employee);
    }
}