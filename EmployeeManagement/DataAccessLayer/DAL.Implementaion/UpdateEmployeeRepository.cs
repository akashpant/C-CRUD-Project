using ConsoleApp2.DataAccessLayer.DAL.Interfaces;
using ConsoleApp2.Model;
using System.Linq;

namespace ConsoleApp2.DataAccessLayer.DAl.Implementation
{
    public class UpdateEmployeeRepository: IUpdateEmployee
    {
        public int UpdateEmployeeDetails(EmployeeModel empModel)
        {
            using (var dbContext = new MyDbContext())
            {
                var result = dbContext.Employee.FirstOrDefault(x => x.Emp_Id == empModel.EmpId);
                result.Emp_Name = empModel.Name;
                result.Emp_Department = empModel.Department;
                return (dbContext.SaveChanges());
            }
            //int value1 = 0;
            //using (SqlConnection conn = new SqlConnection("server =.; Database = akashdb; Trusted_Connection = true;"))
            //{
            //    conn.Open();
            //    var sql = "Update_Employee"; // here too
            //    using (SqlCommand cmd = new SqlCommand(sql, conn))
            //    {
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.Parameters.AddWithValue("@Eid", empModel.EmpId);
            //        cmd.Parameters.AddWithValue("@Ename", empModel.Name);
            //        cmd.Parameters.AddWithValue("@Edept", empModel.Department);
            //        value1 = cmd.ExecuteNonQuery();
            //    }

            //    conn.Close();
            //}
            //return value1;
        }
    }
}
