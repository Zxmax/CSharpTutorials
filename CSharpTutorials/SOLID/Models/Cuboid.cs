namespace CSharpTutorials.SOLID.Models
{
    public class Cuboid : IShapeInterface, ISolidShapeInterface,IManageShapeInterface
    {
        public double Area()
        {
            throw new System.NotImplementedException();
        }

        public double Volume()
        {
            throw new System.NotImplementedException();
        }

        public double Calculate()
        {
            return Area() + Volume();
        }
    }
}