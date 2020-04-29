using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp2.Model
{
    public class MyDbContext : DbContext
    {
        public DbSet<Employees> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;Database=akashdb;Trusted_Connection=true;");
        }
    }

    public class Employees // poco class
    {
        [Key]
        public int Id { get; set; }
        public int Emp_Id { get; set; }
        public string Emp_Name { get; set; }
        public string Emp_Department { get; set; }

    }
}
