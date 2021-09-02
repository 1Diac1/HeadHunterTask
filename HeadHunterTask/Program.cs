using HeadHunterTaskLibrary.Shapes;
using HeadHunterTaskLibrary;
using System;

namespace HeadHunterTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape triangle = new Triangle("Shape 1", 5, 12, 13);
            Shape circle = new Circle("Shape 2", 20);
            Triangle triangle2 = new Triangle("Shape 3", 3, 4, 2);
            Triangle triangle3 = new Triangle("Shape 4", 3, 4, 5);

            Console.WriteLine(ShapeType.GetArea(triangle));
            Console.WriteLine(triangle2.ToString() + ". Is rect: " + triangle2.IsTriangleRectangular() + ". Is exist: " + triangle3.IsTriangleExist());
            Console.WriteLine(triangle3.ToString() + ". Is rect: " + triangle3.IsTriangleRectangular() + ". Is exist: " + triangle3.IsTriangleExist());
            Console.WriteLine(circle.ToString());
        }
    }
}
