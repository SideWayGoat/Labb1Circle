using System;

namespace Labb1Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle TheArea = new Circle(6);
            Console.WriteLine("The area is : {0} CM", TheArea.getArea());

            Circle around = new Circle(6);
            Console.WriteLine("The Circumference is : {0} CM ", around.getCircumference());

            Circle one = new Circle(6);
            Console.WriteLine("The Surface Area is : {0} CM", one.surfaceArea());

            Circle sphere = new Circle(6);
            Console.WriteLine("The Volume is : {0} CM", sphere.sphereVolume());
        }
    }
}
