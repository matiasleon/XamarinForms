using System;
using hxTest.Utilities;
using hxTest.ViewModel;
using Microsoft.Practices.Unity;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace hxTest.Views.Employees
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmployeeList : ContentPage
    {
        public EmployeeList()
        {
            InitializeComponent();

            var viewModel = AppContainer.Container.Resolve(typeof(ListEmployeeViewModel));
            BindingContext = viewModel;
            EmployeeListView.ItemSelected += EmployeeListView_ItemSelected;
        }

        private void EmployeeListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Navigation.PushAsync(new DetailEmployeePage(), true);
        }

        private void MenuItem_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewEmployeePage());
        }
    }
}