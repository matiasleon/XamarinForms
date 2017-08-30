using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hxTest.Business.Employees;
using hxTest.IServices.Employees;
using Xamarin.Forms;

namespace hxTest.ViewModel
{
    public class ListEmployeeViewModel 
    {
        private readonly IEmployeeService employeeService;

        public IList<Employee> Employees { get; set; }

        public ListEmployeeViewModel(IEmployeeService employeeService)
        {           
            this.employeeService = employeeService;
            this.GetEmployees();
        }

        public async Task GetEmployees()
        {
            this.Employees = await this.employeeService.GetAll();
        } 
    }
}