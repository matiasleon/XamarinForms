using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using hxTest.Business.Employees;
using hxTest.IServices.Employees;
using Xamarin.Forms;

namespace hxTest.ViewModel
{
    public class ListEmployeeViewModel 
    {
        private readonly IEmployeeService employeeService;

        private ObservableCollection<Employee> employees = new ObservableCollection<Employee>();

        public ListEmployeeViewModel(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        public ObservableCollection<Employee> Employees
        {
            get
            {
                var employeesList = this.employeeService.GetAll();
                foreach (var employee in employeesList)
                {
                    this.employees.Add(employee);
                }

                return employees;
            }
        }
    }
}