using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using System.Reflection;
using AutoFacTest.Interfaces;
using AutoFacTest.Classes;

namespace AutoFacTest
{
    public class Server
    {
        static IContainer _container;

        public void RegisterContainer()
        {
            ContainerBuilder builder = new ContainerBuilder();
            Assembly executingAssembly = Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(executingAssembly).AsSelf().AsImplementedInterfaces();

            _container = builder.Build();
        }

        public void Execute()
        {
            TestController n = _container.Resolve<TestController>();
            n.Execute();
        }

        public void ShutDown()
        {
            _container.Dispose();
        }
    }
}
