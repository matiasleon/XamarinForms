using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using hxTest.Business.Employees;
using Xamarin.Forms;

namespace hxTest.ViewModel
{
    public class DetailEmployeePageViewModel
    {
        public Employee Employee { get; set; }

        public ICommand UpdateCommand { get; set; }

        public DetailEmployeePageViewModel()
        {
            UpdateCommand = new Command(Update);
        }

        private async void Update()
        {
            
        }
    }
}
