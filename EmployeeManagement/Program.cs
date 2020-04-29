using Autofac;
using ConsoleApp2;
using ConsoleApp2.Startup;

public class Program
{
    static void Main()
    {
        var container = ContainerConfig.Configure();
        using (var scope = container.BeginLifetimeScope())
        {
            var app = scope.Resolve<IApplicationStartup>();
            app.Run();
        }
    }
}