using System;
using CSharpTutorials.SOLID.Controller;

namespace CSharpTutorials.SOLID.Models
{
    public class Circle : IShapeInterface,IManageShapeInterface
    {
        public double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double Calculate()
        {
            return Area();
        }
    }
}