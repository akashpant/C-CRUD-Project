using ConsoleApp2.Model;

namespace ConsoleApp2.DataAccessLayer.DAL.Interfaces
{
    interface ICreateEmployee
    {
        int CreateEmployee(EmployeeModel empModel);
    }
}
