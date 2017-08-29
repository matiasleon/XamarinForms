using System.Collections.Generic;
using hxTest.Business.Employees;

namespace hxTest.IServices.Employees
{
    public interface IEmployeeService
    {
        IList<Employee> GetAll();
    }
}
