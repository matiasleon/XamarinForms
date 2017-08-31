using System;
using hxTest.Business.Employees;
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
            var item = (Employee)e.SelectedItem;
            var detailPage = new DetailEmployeePage(item);
            Navigation.PushAsync(detailPage, true);
        }

        private void MenuItem_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewEmployeePage());
        }
    }
}