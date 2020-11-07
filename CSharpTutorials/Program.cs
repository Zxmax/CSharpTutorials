using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("C#基础");
            byte a = 200;
            byte b = 100;
            var c = a + b;
            Console.WriteLine(a += b);
        }
    }
}
