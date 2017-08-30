using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using hxTest.IServices.Employees;
using Xamarin.Forms;

namespace hxTest.ViewModel
{
    public class NewEmployeePageViewModel
    {
        public string Office { get; set; }

        public string Name { get; set; }

        public string Username { get; set; }

        public ICommand SaveCommand { get; set; }

        private readonly IEmployeeService employeeService;

        public NewEmployeePageViewModel(IEmployeeService employeeService)
        {
            SaveCommand = new Command(Save);
            this.employeeService = employeeService;
        }

        private async void Save()
        {
            await this.employeeService.Create(this.Name, this.Office, this.Username);
        }
    }
}
