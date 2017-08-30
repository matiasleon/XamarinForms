using System.Collections.Generic;
using System.Threading.Tasks;
using hxTest.Business.Employees;

namespace hxTest.Business.Common
{
    public interface IRepository
    {
        Task<IList<Employee>> GetAll();

        Task<int> SaveAsync(Employee employee);
    }
}
