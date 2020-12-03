using System.Collections.Generic;
using System.Linq;
using CSharpTutorials.SOLID.Models;

namespace CSharpTutorials.SOLID.Controller
{ 
    public class VolumeCalculator :AreaCalculator
    {
        public VolumeCalculator(IShapeInterface[] shapes) : base(shapes)
        {
        }

        public new double[] Sum()
        {
            var areas = new List<double>();
            //分别计算每个图形的面积，返回面积数组
            foreach (var shape in Shapes)
            {
                areas.ToList().Add(shape.Area());
            }
            return areas.ToArray();
        }
    }
}