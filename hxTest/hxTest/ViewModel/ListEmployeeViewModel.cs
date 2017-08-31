using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hxTest.Business.Employees;
using hxTest.Common;
using hxTest.IServices.Employees;
using Xamarin.Forms;

namespace hxTest.ViewModel
{
    public class ListEmployeeViewModel 
    {
        private readonly IEmployeeService employeeService;

        public ObservableCollection<Employee> EmployeesSource { get; set; }

        public ListEmployeeViewModel(IEmployeeService employeeService)
        {           
            this.employeeService = employeeService;
            EmployeesSource = new ObservableCollection<Employee>();
            InitEmployees();
            SubscribeNewEmployeeEvent();
        }

        public void InitEmployees()
        {
            var employeesResults = Task.Run(async () => await this.employeeService.GetAll()).Result;
            foreach (var employee in employeesResults)
            {
                EmployeesSource.Add(employee);
            }
        }

        private void SubscribeNewEmployeeEvent()
        {
            MessagingCenter.Subscribe<NewEmployeePageViewModel,Employee>(this, MessengerKeys.EmployeeCreated, (sender, newEmployee) =>
            {
                EmployeesSource.Add(newEmployee);                
            });
        }
    }
}