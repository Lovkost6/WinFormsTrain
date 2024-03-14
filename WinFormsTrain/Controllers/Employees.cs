

using WinFormsTrain.Models;

namespace WinFormsTrain.Controllers
{
    static internal class Employees
    {
        static public int CreateEmployee(string lastName, string firstName, string surName,string jobTitle,int salary)
        {
            var employee = new Employee
            {
                LastName = lastName,
                FirstName = firstName,
                SurName = surName,
                JobTitle = jobTitle,
                Salary = salary
            };
            using var hrd = new HRDContext();
            hrd.Employees.Add(employee);
            hrd.SaveChanges();
            return employee.Id;
        }

        static public Employee GetEmployeeById(int employeeId)
        {
            using var hrd = new HRDContext();
            var employee = hrd.Employees.FirstOrDefault(s => s.Id == employeeId);
            return employee;
        }

        static public List<Employee> GetAllEmployees()
        {
            using var hrd = new HRDContext();
            return hrd.Employees.ToList();
        }
    }
}
