using System.Threading.Tasks;
using hxTest.Business.Common;
using hxTest.Business.Employees.Factories;

namespace hxTest.Business.Employees.Core
{
    public class EmployeeGenerator
    {
        private readonly IRepository repository;

        private readonly EmployeeFactory factory;

        public EmployeeGenerator(IRepository repository, EmployeeFactory factory)
        {
            this.repository = repository;
            this.factory = factory;
        }

        public async Task<Employee> Generate(string name, string office, string username)
        {
            var employee = this.factory.Create(name, office, username);
            await this.repository.SaveAsync(employee);

            return employee;
        }
    }
}
