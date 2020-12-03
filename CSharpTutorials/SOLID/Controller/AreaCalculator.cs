using System;
using System.Linq;
using CSharpTutorials.SOLID.Models;

namespace CSharpTutorials.SOLID.Controller
{
    public class AreaCalculator
    {
        protected IShapeInterface[] Shapes;

        public AreaCalculator(IShapeInterface[] shapes)
        {
            Shapes = shapes;
        }

        public double Sum()
        {
            //计算面积和
            return Shapes.Sum(shape => shape.Area());
        }

        public void Output()
        {
            Console.WriteLine("面积和是:" + Sum());
        }

        internal void JsonOutput()
        {
            throw new NotImplementedException();
        }

        internal void HtmlOutput()
        {
            throw new NotImplementedException();
        }

        internal void HamlOutput()
        {
            throw new NotImplementedException();
        }

        internal void JadeOutput()
        {
            throw new NotImplementedException();
        }
    }
}