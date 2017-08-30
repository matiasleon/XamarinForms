using SQLite.Net.Async;
using System.Collections.Generic;
using System.Threading.Tasks;
using hxTest.Business.Employees;

namespace hxTest.Data
{
    public class Database
    {
        private readonly SQLiteAsyncConnection connection; 

        public Database(SQLiteAsyncConnection connection)
        {
            this.connection = connection;
            this.connection.CreateTableAsync<Employee>().Wait();
        }

        public async Task<IList<Employee>> GetItemAsync()
        {
            return await this.connection.Table<Employee>().ToListAsync(); 
        }

        public async Task<int> SaveAsync(Employee employee)
        {
            return await this.connection.InsertAsync(employee);
        }
    }
}
