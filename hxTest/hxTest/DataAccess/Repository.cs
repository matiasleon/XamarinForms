using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hxTest.Business.Common;
using hxTest.Business.Employees;
using hxTest.Data;

namespace hxTest.DataAccess
{
    public class Repository : IRepository
    {
        private readonly Database database;

        public Repository(Database database)
        {
            this.database = database;
        }

        public Task<IList<Employee>> GetAll()
        {
            return this.database.GetItemAsync();
        }

        public Task<int> SaveAsync(Employee employee)
        {
            return this.database.SaveAsync(employee);
        }
    }
}
