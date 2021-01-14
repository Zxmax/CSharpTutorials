using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Autofac;
using CSharpTutorials.Autofac.Model;
using CSharpTutorials.Autofac.Model.Interface;
using CSharpTutorials.LanguageReference;
using CSharpTutorials.SOLID.Controller;
using CSharpTutorials.SOLID.Models;

namespace CSharpTutorials
{
    internal class Program
    {
        private static IContainer Container { get; set; }
        private static void Main()
        {
            var build=new ContainerBuilder();
            build.RegisterType<ConsoleOutput>().As<IOutput>();
            build.RegisterType<TodayWrite>().As<IDateWriter>();
            Container = build.Build();

            WriteDate();
        }

        private static void WriteDate()
        {
            using var scope=Container.BeginLifetimeScope();
            var write = scope.Resolve<IDateWriter>();
            write.WriteDate();
        }
    }
}
