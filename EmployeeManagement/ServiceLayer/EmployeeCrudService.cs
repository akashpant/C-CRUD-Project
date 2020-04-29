using ConsoleApp2.Model;
using ConsoleApp2.DataAccessLayer.DAL.Interfaces;

namespace ConsoleApp2.ServiceLayer
{
    class EmployeeCrudService : IEmployeeCrudService
    {
        private ICreateEmployee _CreateEmployeeRepository;
        public EmployeeCrudService(ICreateEmployee CreateEmployee)
        {
            _CreateEmployeeRepository = CreateEmployee;
        } 
        private IReadEmployee _ReadEmployeeRepository;
        public EmployeeCrudService(IReadEmployee ReadEmployee)
        {
            _ReadEmployeeRepository = ReadEmployee;
        }
        private IUpdateEmployee _UpdateEmployeeRepository;
        public EmployeeCrudService(IUpdateEmployee UpdateEmployee)
        {
            _UpdateEmployeeRepository = UpdateEmployee;
        } 
        private IDeleteEmployee _DeleteEmployeeRepository;
        public EmployeeCrudService(IDeleteEmployee DeleteEmployee)
        {
            _DeleteEmployeeRepository = DeleteEmployee;
        }

        public int CreateEmployee(EmployeeModel empModel)
        {
           return _CreateEmployeeRepository.CreateEmployee(empModel); 
        }

        public int DeleteEmployee(int empId)
        {
            return _DeleteEmployeeRepository.DeleteEmployee(empId);
        }

        public EmployeeModel ReadEmployee(int id)
        {
            return _ReadEmployeeRepository.ReadEmployee(id);
        }

        public int UpdateEmployeeDetails(EmployeeModel empModel)
        {
            return _UpdateEmployeeRepository.UpdateEmployeeDetails(empModel);
        }

}
      
}
