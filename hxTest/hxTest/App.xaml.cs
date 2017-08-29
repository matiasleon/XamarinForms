using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using hxTest.Utilities;
using hxTest.Views;
using Xamarin.Forms;

namespace hxTest
{
    public partial class App : Application
    {
        public App(AppSetup setup)
        {

            AppContainer.Container = setup.CreateContainer();
            MainPage = new NavigationPage(new EmployeeList());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
