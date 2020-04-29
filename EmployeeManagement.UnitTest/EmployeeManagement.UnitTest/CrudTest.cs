using ConsoleApp2.DataAccessLayer.DAl.Implementation;
using ConsoleApp2.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeeManagement.UnitTest
{
    [TestClass]
    public class CrudTest
    {
        [TestMethod]
        public void CreateEmployeeTest()
        {
            var repo = new CreateEmployeeRepository();

            var mockModel = new EmployeeModel()
            {
                EmpId = 5,
                Name = "Test Empolyee",
                Department = "Test Department"
            };

            Assert.AreEqual(repo.CreateEmployee(mockModel), 1);
        }

        [TestMethod]
        public void ReadEmployeeTest()
        {
            var repo = new ReadEmployeeRepository();

            var empModel = repo.ReadEmployee(5);

            Assert.AreEqual(empModel.Name, "Test Empolyee");
        }

        [TestMethod]
        public void UpdateEmployee()
        {
            var repo = new UpdateEmployeeRepository();

            var mockModel = new EmployeeModel()
            {
                EmpId = 5,
                Name = "Update From TestCase",
                Department = "Updated Department"
            };

            Assert.AreEqual(repo.UpdateEmployeeDetails(mockModel), 1);
        }

        [TestMethod]
        public void ZDeleteEmployee()
        {
            var repo = new DeleteEmployeeRepository();

            Assert.AreEqual(repo.DeleteEmployee(5), 1);

        }

    }
}
