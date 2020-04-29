using ConsoleApp2.Model;

namespace ConsoleApp2.ServiceLayer
{
    interface IEmployeeCrudService
    {
        int CreateEmployee(EmployeeModel empModel);

        EmployeeModel ReadEmployee(int id);

        int UpdateEmployeeDetails(EmployeeModel empModel);

        int DeleteEmployee(int empId);
    }
}
