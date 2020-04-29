using ConsoleApp2.Model;

namespace ConsoleApp2.BusinessAccessLayer.BAL.Interfaces
{
    public interface ICreateEmployee
    { 
        int CreateEmp(EmployeeModel empModel);
    }
}