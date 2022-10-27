using System;

namespace Labb1Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle area5 = new Circle(5);
            Console.WriteLine(area5.getArea() + " CM");

            Circle around = new Circle(5);
            Console.WriteLine(around.getCircumference() + " CM");

            Circle one = new Circle(5);
            Console.WriteLine(one.sphereArea() + " CM");
        }
    }
}
