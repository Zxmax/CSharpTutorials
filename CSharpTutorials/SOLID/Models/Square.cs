using System;
using System.Reflection.Metadata.Ecma335;

namespace CSharpTutorials.SOLID.Models
{
    public class Square : IShapeInterface,IManageShapeInterface
    {
        public double Length;

        public Square(double length)
        {
            Length = length;
        }
        public double Area()
        {
            return Math.Pow(Length, 2);
        }

        public double Calculate()
        {
            return Area();
        }
    }
}