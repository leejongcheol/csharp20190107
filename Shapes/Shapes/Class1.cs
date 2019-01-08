using System;
namespace Shapes
{
    public class Circle
    {
        double radius;

        //Circle c = new Circle();
        public  Circle()  //new할때 호출, 기본생성자
        {
            radius = 0;
        }
        //Circle c = new Circle(10);
        public Circle(double radius)
        {
            this.radius = radius;
        }

        //Circle c = new Circle(100);
        //Console.WriteLine(c.Area());
        public double Area()
        {
            return Math.PI * (radius * radius);
        }
    }
}