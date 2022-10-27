using System;

namespace Labb1Circle
{
    public class Circle
    {
        public float pi = 3.141f;
        public int radius;
        
        public Circle(int _Radius)
        {
            this.radius = _Radius;
        }

        public float getArea()
        {
            return (radius * radius) * pi;
        }
        public float getCircumference()
        {
            return (radius + radius) * pi;
        }
        public float sphereArea()
        {
            return 4 * pi * radius * radius;
        }
    }
}
