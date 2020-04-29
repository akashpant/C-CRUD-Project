using ConsoleApp2.BusinessAccessLayer.BAL.Interfaces;
using ConsoleApp2.ServiceLayer;
using System;

namespace ConsoleApp2.BusinessAccessLayer.BAL.Implementation
{
    class DeleteEmployee : IDeleteEmployee
    {
        private readonly IEmployeeCrudService _IEmployeeCrudService;

        public DeleteEmployee(IEmployeeCrudService EmployeeCrudServices)
        {
           ;
            _IEmployeeCrudService = EmployeeCrudServices;
        }
        int isEmpDeleted;
        public int DeleteEmployees(int empId)
        {
            try
            {
                //DeleteEmployeeRepository del = new DeleteEmployeeRepository();
                isEmpDeleted = _IEmployeeCrudService.DeleteEmployee(empId);
                
            }
            catch (Exception e)
            {
                textlogger.Text( e.Message.ToString());
            }
            return isEmpDeleted;
        }

    }
}
