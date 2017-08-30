using System.Collections.Generic;
using System.Threading.Tasks;
using hxTest.Business.Employees;
using hxTest.Business.Employees.Core;
using hxTest.Business.Employees.Searchers;
using hxTest.IServices.Employees;

namespace hxTest.Services.Employees
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EmployeeSearcher employeeSearcher;

        private readonly EmployeeGenerator generator;

        public EmployeeService(EmployeeSearcher employeeSearcher, EmployeeGenerator generator)
        {
            this.employeeSearcher = employeeSearcher;
            this.generator = generator;
        }

        public async Task<IList<Employee>> GetAll()
        {
            return await this.employeeSearcher.GetAll();
        }

        public async Task Create(string name, string office, string username)
        {
            await this.generator.Generate(name, office, username);
        }
    }
}
