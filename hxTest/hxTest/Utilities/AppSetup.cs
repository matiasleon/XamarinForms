using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using hxTest.Business.Employees.Searchers;
using hxTest.IServices.Employees;
using hxTest.Services.Employees;
using hxTest.ViewModel;

namespace hxTest.Utilities
{
    public class AppSetup
    {
        public IContainer CreateContainer()
        {
            var containerBuilder = new ContainerBuilder();
            RegisterDependencies(containerBuilder);
            return containerBuilder.Build();
        }

        protected virtual void RegisterDependencies(ContainerBuilder cb)
        {
            cb.RegisterType<EmployeeService>().As<IEmployeeService>();
            cb.RegisterType<ListEmployeeViewModel>();
            cb.RegisterType<EmployeeSearcher>();
        }
    }
}
