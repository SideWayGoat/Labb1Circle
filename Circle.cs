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
        public float surfaceArea()
        {
            return 4 * pi * radius * radius;
        }
        public float sphereVolume()
        {
            return (float)(4.0 / 3 * pi * radius * radius * radius);
        }
    }
}
