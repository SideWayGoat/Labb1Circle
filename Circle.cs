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
            return radius * radius * pi;
        }
    }
}
