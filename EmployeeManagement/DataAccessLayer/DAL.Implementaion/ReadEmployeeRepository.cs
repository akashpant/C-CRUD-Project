using ConsoleApp2.DataAccessLayer.DAL.Interfaces;
using ConsoleApp2.Model;
using System.Linq;

namespace ConsoleApp2.DataAccessLayer.DAl.Implementation
{
    public class ReadEmployeeRepository : IReadEmployee
    {
        public EmployeeModel ReadEmployee(int id)
        {
            using (var dbContext = new MyDbContext())
            {
                var result = dbContext.Employee.FirstOrDefault(x=>x.Emp_Id == id);

                var empModel = new EmployeeModel()
                {
                    EmpId = result.Emp_Id,
                    Name = result.Emp_Name,
                    Department = result.Emp_Department
                };

                return empModel;
            }
            //using (var conn = new SqlConnection("server=.;Database=akashdb;Trusted_Connection=true;"))
            //{
            //    conn.Open();
            //    var sql = "Read_Employee";// not required
            //    using (var cmd = new SqlCommand(sql, conn))
            //    {
            //        var dtable = new DataTable();
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.Parameters.AddWithValue("@Eid", id);
            //        using (var adapter = new SqlDataAdapter(cmd))
            //        {
            //            var table = new DataTable();
            //            adapter.Fill(table);
            //            foreach (DataRow item in table.Rows)
            //            {
            //                empModel.EmpId = Convert.ToInt32(item["Emp_ID"]);
            //                empModel.Name = item["emp_name"].ToString();
            //                empModel.Department = item["emp_department"].ToString();
            //            }
            //        }
            //        conn.Close();
        }
    }
}
