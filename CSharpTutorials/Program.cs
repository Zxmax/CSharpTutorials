using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CSharpTutorials.LanguageReference;
using CSharpTutorials.SOLID.Controller;
using CSharpTutorials.SOLID.Models;

namespace CSharpTutorials
{
    internal class Program
    {
        private static void Main()
        {
            IShapeInterface[] shapes =
            {
                new Circle(2),
                new Square(5),
                new Square(6),
            };
            
            var volume = new VolumeCalculator(shapes);
            AreaCalculator areas = volume;
            var aS=areas.Sum();
            var vS=volume.Sum();
        }
    }
}
