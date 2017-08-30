using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hxTest.Business.Common;

namespace hxTest.Business.Employees.Searchers
{
    public class EmployeeSearcher
    {
        private readonly IRepository repository;

        public EmployeeSearcher(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IList<Employee>> GetAll()
        {
            return await this.repository.GetAll();
        }
    }
}
