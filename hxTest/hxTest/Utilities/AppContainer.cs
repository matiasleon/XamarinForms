using System;
using hxTest.Common;
using hxTest.Data;
using hxTest.DataAccess;
using hxTest.IServices.Employees;
using hxTest.Services.Employees;
using Microsoft.Practices.Unity;
using SQLite.Net;
using SQLite.Net.Async;
using Xamarin.Forms;
using hxTest.Business.Common;

namespace hxTest.Utilities
{
    public static class AppContainer
    {
        public static UnityContainer Container;

        public static void Init()
        {
            Container = new UnityContainer();
        }

        public static void RegisterDependencies()
        {
            RegisterDatabase();
            Container.RegisterType<IEmployeeService, EmployeeService>();
            Container.RegisterType<IRepository, Repository>();
        }

        public static void RegisterCustomInterface ()
        {
            
        }

        private static void RegisterDatabase()
        {
            var fileHelper = DependencyService.Get<IFileHelper>();
            var sqLiteConnectionString = new SQLiteConnectionString(fileHelper.GetLocalFilePath("employees.db3"), false);
            var plataform = DependencyService.Get<IPlataform>();
            var sqlLiteAsyncConnection =
                new SQLiteAsyncConnection(() =>
                    new SQLiteConnectionWithLock(plataform.GetPlatform(),sqLiteConnectionString));
            Container.RegisterType<Database>(new InjectionConstructor(sqlLiteAsyncConnection));
        }
    }
}
