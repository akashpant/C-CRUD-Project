using ConsoleApp2.Model;

namespace ConsoleApp2.BusinessAccessLayer.BAL.Interfaces
{
    interface IReadEmployee
    {
       EmployeeModel ReadEmp(int empId);
    }
}
