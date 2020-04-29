using Autofac;
using ConsoleApp2.BusinessAccessLayer.BAL.Implementation;
using ConsoleApp2.DataAccessLayer.DAl.Implementation;
using ConsoleApp2.ServiceLayer;
using ConsoleApp2.Startup;

namespace ConsoleApp2
{
    static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ApplicationStartup>().As<IApplicationStartup>();
            builder.RegisterType<CreateEmployee>().As<BusinessAccessLayer.BAL.Interfaces.ICreateEmployee>();
            builder.RegisterType<DeleteEmployee>().As<BusinessAccessLayer.BAL.Interfaces.IDeleteEmployee>();
            builder.RegisterType<ReadEmployee>().As<BusinessAccessLayer.BAL.Interfaces.IReadEmployee>();
            builder.RegisterType<UpdateEmployee>().As<BusinessAccessLayer.BAL.Interfaces.IUpdateEmployee>();
            builder.RegisterType<CreateEmployeeRepository>().As<DataAccessLayer.DAL.Interfaces.ICreateEmployee>();
            builder.RegisterType<ReadEmployeeRepository>().As<DataAccessLayer.DAL.Interfaces.IReadEmployee>();
            builder.RegisterType<UpdateEmployeeRepository>().As<DataAccessLayer.DAL.Interfaces.IUpdateEmployee>();
            builder.RegisterType<DeleteEmployeeRepository>().As<DataAccessLayer.DAL.Interfaces.IDeleteEmployee>();
            builder.RegisterType<EmployeeCrudService>().As<IEmployeeCrudService>();
            return builder.Build();
        }
    }
}
