using hxTest.Business.Common;
using System;

namespace hxTest.Business.Employees
{
    public class Employee : PersistibleEntity<Guid>
    {
        public Employee(string name, string office, string username)
        {
            this.Name = name;
            this.Office = office;
            this.Username = username;
        }

        public string Name { get; set; }

        public string Username { get; set; }

        public string Office { get; set; }
    }
}
