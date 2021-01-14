using System;
using CSharpTutorials.Autofac.Model.Interface;

namespace CSharpTutorials.Autofac.Model
{
    public class ConsoleOutput : IOutput
    {
        public void Write(string content)
        {
            Console.WriteLine(content);
        }
    }
}