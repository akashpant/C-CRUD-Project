using ConsoleApp2.DataAccessLayer.DAL.Interfaces;
using ConsoleApp2.Model;

namespace ConsoleApp2.DataAccessLayer.DAl.Implementation
{
    public class CreateEmployeeRepository : ICreateEmployee
    {
        public int CreateEmployee(EmployeeModel empModel)
        {
            using (var dbContext = new MyDbContext())
            {
                var empData = new Employees()
                {
                    Emp_Id = empModel.EmpId,
                    Emp_Name = empModel.Name,
                    Emp_Department = empModel.Department
                };

                dbContext.Add(empData);
                return (dbContext.SaveChanges());
            }

            //using (var conn = new SqlConnection("server=.;Database=akashdb;Trusted_Connection=true;"))
            //{
            //    conn.Open();
            //    var sql = "Insert_EMP";
            //    using (var cmd = new SqlCommand(sql, conn))
            //    {
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.Parameters.AddWithValue("@Eid", empModel.EmpId);
            //        cmd.Parameters.AddWithValue("@Ename", empModel.Name);
            //        cmd.Parameters.AddWithValue("@Edept", empModel.Department);

            //        isValueInserted = cmd.ExecuteNonQuery();
            //    }
            //    conn.Close();
            //}
            //return isValueInserted;
        }
    }
}
