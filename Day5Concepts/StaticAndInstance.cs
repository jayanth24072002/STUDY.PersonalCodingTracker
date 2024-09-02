using System;

namespace Day5Concepts.StaticAndInstance
{
   class Circle
    {
        static float pi;
        int _radius;

        static Circle() //static constructor
        {
            Console.WriteLine("static constructor called");
            Circle.pi = 3.14f;
        }

        public Circle(int radius)
        {
            Console.WriteLine("Instance constructor called");
            this._radius = radius;
        }

        public float CalculatedArea()
        {
            return Circle.pi * this._radius * this._radius;
        }
    }
}
