
namespace hxTest.Business.Employees.Factories
{
    public class EmployeeFactory
    {
        public Employee Create(string name, string office, string username)
        {
            return new Employee(name, office, username);
        }
    }
}