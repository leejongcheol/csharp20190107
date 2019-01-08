using System;
using Shapes;
namespace ShapeUser
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(10);
            Console.WriteLine($"반지름10인 원의 면적{c.Area()}");
        }
    }
}
