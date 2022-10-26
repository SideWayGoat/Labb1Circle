using System;

namespace Labb1Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle area5 = new Circle(5);
            Console.WriteLine(area5.getArea());

            Circle area6 = new Circle(6);
            Console.WriteLine(area6.getArea());
        }
    }
}
