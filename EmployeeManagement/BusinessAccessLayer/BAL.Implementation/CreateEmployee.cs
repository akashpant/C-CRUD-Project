using ConsoleApp2.Model;
using ConsoleApp2.BusinessAccessLayer.BAL.Interfaces;
using ConsoleApp2.ServiceLayer;
using System;

namespace ConsoleApp2.BusinessAccessLayer.BAL.Implementation
{
    class CreateEmployee : ICreateEmployee
    {
        private readonly IEmployeeCrudService _IEmployeeCrudService;

        public CreateEmployee(IEmployeeCrudService EmployeeCrudService)
        {
            _IEmployeeCrudService = EmployeeCrudService;
        }

        int isempInserted;
            
        public int CreateEmp(EmployeeModel empModel)
        {
            try
            {
                isempInserted = _IEmployeeCrudService.CreateEmployee(empModel);
                //CreateEmployeeRepository emp = new CreateEmployeeRepository();
                //isempInserted = emp.CreateEmployee(empModel);
            }

            catch (Exception e)
            {
                textlogger.Text(e.Message.ToString());
            }
            return isempInserted;
        }
    }
}
