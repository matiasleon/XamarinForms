using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hxTest.Views;
using Xamarin.Forms;

namespace hxTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var navigation= new NavigationPage();
            navigation.PushAsync(new EmployeeList());
        }
    }
}
