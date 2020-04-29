using ConsoleApp2.BusinessAccessLayer.BAL.Interfaces;
using ConsoleApp2.ServiceLayer;
using System;
using ConsoleApp2.Model;

namespace ConsoleApp2.BusinessAccessLayer.BAL.Implementation
{
    class ReadEmployee : IReadEmployee
    {
        private readonly IEmployeeCrudService _IEmployeeCrudService;
        public ReadEmployee(IEmployeeCrudService EmployeeCrudService)
        {
            _IEmployeeCrudService = EmployeeCrudService;
        }
        EmployeeModel result;
        public EmployeeModel ReadEmp(int empId)
        {
            try
            {

                //ReadEmployeeRepository read = new ReadEmployeeRepository();
                result = _IEmployeeCrudService.ReadEmployee(empId);

            }
            catch (Exception e)
            {
                textlogger.Text(e.Message.ToString());
            }
            return result;
        }
    }
}
