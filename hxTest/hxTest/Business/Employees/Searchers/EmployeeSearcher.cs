using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hxTest.Business.Employees.Searchers
{
    public class EmployeeSearcher
    {
        public EmployeeSearcher()
        {
            
        }

        public IList<Employee> GetAll()
        {
            var employees = new List<Employee>(); 
            employees.Add(new Employee(){Name = "Matias",Username = "unUsername"});
            employees.Add(new Employee(){Name = "Dani",Username = "unUsername"});
            employees.Add(new Employee() { Name = "Carlos", Username = "unUsername" });
            employees.Add(new Employee() { Name = "Messi", Username = "unUsername" });
            employees.Add(new Employee() { Name = "Messi", Username = "unUsername" });
            employees.Add(new Employee() { Name = "Messi", Username = "unUsername" });
            employees.Add(new Employee() { Name = "Messi", Username = "unUsername" });
            employees.Add(new Employee() { Name = "Messi", Username = "unUsername" });
            employees.Add(new Employee() { Name = "Messi", Username = "unUsername" });
            employees.Add(new Employee() { Name = "Messi", Username = "unUsername" });
            employees.Add(new Employee() { Name = "Messi", Username = "unUsername" });
            employees.Add(new Employee() { Name = "Messi", Username = "unUsername" });
            employees.Add(new Employee() { Name = "Dani", Username = "unUsername" });
            employees.Add(new Employee() { Name = "Carlos", Username = "unUsername" });
            employees.Add(new Employee() { Name = "Messi", Username = "unUsername" });
            employees.Add(new Employee() { Name = "Messi", Username = "unUsername" });
            employees.Add(new Employee() { Name = "Messi", Username = "unUsername" });
            employees.Add(new Employee() { Name = "Messi", Username = "unUsername" });
            employees.Add(new Employee() { Name = "Messi", Username = "unUsername" });
            employees.Add(new Employee() { Name = "Messi", Username = "unUsername" });
            employees.Add(new Employee() { Name = "Messi", Username = "unUsername" });
            employees.Add(new Employee() { Name = "Messi", Username = "unUsername" });
            employees.Add(new Employee() { Name = "Messi", Username = "unUsername" });

            return employees;
        }
    }
}
