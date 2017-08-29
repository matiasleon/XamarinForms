using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hxTest.Business.Employees;
using hxTest.Business.Employees.Searchers;
using hxTest.IServices.Employees;

namespace hxTest.Services.Employees
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EmployeeSearcher employeeSearcher;

        public EmployeeService(EmployeeSearcher employeeSearcher)
        {
            this.employeeSearcher = employeeSearcher;
        }

        public IList<Employee> GetAll()
        {
            return this.employeeSearcher.GetAll();
        }
    }
}
