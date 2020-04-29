using ConsoleApp2.BusinessAccessLayer.BAL.Interfaces;
using ConsoleApp2.ServiceLayer;
using System;
using ConsoleApp2.Model;

namespace ConsoleApp2.BusinessAccessLayer.BAL.Implementation
{
    class UpdateEmployee : IUpdateEmployee
    {
        private readonly IEmployeeCrudService _IEmployeeCrudService;
        public UpdateEmployee(IEmployeeCrudService EmployeeCrudService)
        {
            _IEmployeeCrudService = EmployeeCrudService;
        }
        int isEmpUpdated;
        public int UpdateEmployees(EmployeeModel empModel)
        {
            try
            {
                //UpdateEmployeeRepository updateEmployee = new UpdateEmployeeRepository();
                isEmpUpdated = _IEmployeeCrudService.UpdateEmployeeDetails(empModel);
                
            }
            catch (Exception e)
            {
                textlogger.Text( e.Message.ToString());
            }
            return isEmpUpdated;
        }
    }
}
