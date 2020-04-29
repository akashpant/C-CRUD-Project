using ConsoleApp2.BusinessAccessLayer.BAL.Interfaces;
using ConsoleApp2.Model;
using System;

namespace ConsoleApp2.Startup
{
    class ApplicationStartup : IApplicationStartup
    {
        private readonly ICreateEmployee _ICreateEmployee;
        private readonly IReadEmployee _IReadEmployee;
        private readonly IUpdateEmployee _IUpdateEmployee;
        private readonly IDeleteEmployee _IDeleteEmployee;

        public ApplicationStartup(ICreateEmployee createEmployee, IReadEmployee IReadEmployee, IUpdateEmployee IUpdateEmployee, IDeleteEmployee IDeleteEmployee)
        {
            _ICreateEmployee = createEmployee;
            _IReadEmployee = IReadEmployee;
            _IUpdateEmployee = IUpdateEmployee;
            _IDeleteEmployee = IDeleteEmployee;
        }

        public void Run()
        {
            try
            {
                Console.WriteLine("Select from the following \n 1.Create Employee \n 2.Read Employee \n 3.Update Employee \n 4.Delete Employee");// new line
                int userChoice = int.Parse(Console.ReadLine());
                {

                    EmployeeModel empModel = new EmployeeModel();
                    int empId;
                    switch (userChoice)
                    {
                        case 1:
                            Console.WriteLine("Enter Employee Id");
                            empModel.EmpId = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Employee Name");
                            empModel.Name = Console.ReadLine();
                            Console.WriteLine("Enter Employee Department");
                            empModel.Department = Console.ReadLine();

                            //CreateEmployee createEmployee = new CreateEmployee();
                            var isEmpInserted = _ICreateEmployee.CreateEmp(empModel);
                            Console.WriteLine((isEmpInserted == 0) ? "Employee is not created" : "Employee is Created");
                            break;

                        case 2:

                            Console.WriteLine("Enter The Employee ID");
                            empId = int.Parse(Console.ReadLine());

                            //ReadEmployee readEmployee = new ReadEmployee();
                            var result = _IReadEmployee.ReadEmp(empId);

                            Console.WriteLine($"{result.EmpId} {result.Name} {result.Department}");
                            break;

                        case 3:
                            Console.WriteLine("Enter the Employee Id you want to Update");
                            empModel.EmpId = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the Employee Name to Update");
                            empModel.Name = Console.ReadLine();
                            Console.WriteLine("Enter the Employee Department to Update");
                            empModel.Department = Console.ReadLine();

                            //UpdateEmployee updateEmployee = new UpdateEmployee();
                            int value = _IUpdateEmployee.UpdateEmployees(empModel);

                            Console.WriteLine((value == 0) ? "Cannot update employee details" : "Employee updated sucessfully");
                            break;

                        case 4:
                            Console.WriteLine("enter the Employee Id you want to delete");
                            empId = int.Parse(Console.ReadLine());

                            //DeleteEmployee deleteEmployee = new DeleteEmployee();
                            int isEmpDeleted = _IDeleteEmployee.DeleteEmployees(empId);

                            Console.WriteLine((isEmpDeleted == 0) ? "record not deleted" : "record deleted");
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                textlogger.Text(e.Message.ToString());
            }
        }
    }
}
