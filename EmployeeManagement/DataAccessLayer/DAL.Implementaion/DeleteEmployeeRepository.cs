using ConsoleApp2.DataAccessLayer.DAL.Interfaces;
using ConsoleApp2.Model;
using System.Linq;

namespace ConsoleApp2.DataAccessLayer.DAl.Implementation
{
    public class DeleteEmployeeRepository : IDeleteEmployee
    {
        int value = 0;
        public int DeleteEmployee(int empId)
        {
            using (var dbContext = new MyDbContext())
            {
                var row = dbContext.Employee.FirstOrDefault(x => x.Emp_Id == empId);
                dbContext.Remove(row);
               value = dbContext.SaveChanges();
            }

            //using (var conn = new SqlConnection("server=.;Database=akashdb;Trusted_Connection=true;"))
            //{
            //    conn.Open();
            //    var sql = "Alter_Employee";
            //    using (var cmd = new SqlCommand(sql, conn))
            //    {
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.Parameters.AddWithValue("@Eid", empModel.EmpId);
            //        value = cmd.ExecuteNonQuery();
            //    }
            //    conn.Close();
            //}
            return value;
        }
    }
}
