using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using hxTest.Business.Employees.Searchers;
using hxTest.Utilities;
using hxTest.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace hxTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmployeeList : ContentPage
    {
        public EmployeeList()
        {
            InitializeComponent();

            var viewModel = AppContainer.Container.Resolve<ListEmployeeViewModel>();
            BindingContext = viewModel;


        }

        private void Toast(object sender, EventArgs e)
        {
            DisplayAlert("Hola","como estas ?","Ok");
        }
    }
}