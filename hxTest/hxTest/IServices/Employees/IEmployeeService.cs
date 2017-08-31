using System.Collections.Generic;
using System.Threading.Tasks;
using hxTest.Business.Employees;

namespace hxTest.IServices.Employees
{
    public interface IEmployeeService
    {
        Task<IList<Employee>> GetAll();

        Task<Employee> Create(string name, string office, string username);
    }
}
