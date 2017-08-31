using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hxTest.Business.Employees;
using hxTest.Utilities;
using hxTest.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.Practices.Unity;

namespace hxTest.Views.Employees
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailEmployeePage : ContentPage
    {
        public DetailEmployeePage(Employee employee)
        {
            InitializeComponent();
            var vm = (DetailEmployeePageViewModel)AppContainer.Container.Resolve(typeof(DetailEmployeePageViewModel));
            vm.Employee = employee;
            BindingContext = vm;
        }
    }
}