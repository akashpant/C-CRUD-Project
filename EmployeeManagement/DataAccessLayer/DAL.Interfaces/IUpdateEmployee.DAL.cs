using ConsoleApp2.Model;

namespace ConsoleApp2.DataAccessLayer.DAL.Interfaces
{
    interface IUpdateEmployee
    {
        int UpdateEmployeeDetails(EmployeeModel empModel);
    }
}