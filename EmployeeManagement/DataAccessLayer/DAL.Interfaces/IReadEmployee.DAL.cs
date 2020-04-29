using ConsoleApp2.Model;

namespace ConsoleApp2.DataAccessLayer.DAL.Interfaces
{
    interface IReadEmployee
    {
        EmployeeModel ReadEmployee(int id);
    }
}
