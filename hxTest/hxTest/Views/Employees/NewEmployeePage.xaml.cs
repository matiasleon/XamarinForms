using System;
using hxTest.Utilities;
using hxTest.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.Practices.Unity;

namespace hxTest.Views.Employees
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewEmployeePage : ContentPage
    {
        public NewEmployeePage()
        {
            InitializeComponent();
            var vm = AppContainer.Container.Resolve(typeof(NewEmployeePageViewModel));
            BindingContext = vm;
        }
    }
}