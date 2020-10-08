using System;

namespace PolimorfismoConVirtual
{
    class Program
    {
        static void Main(string[] args)
        {
            var polygon = (Polygon) new Triangle();
            polygon.Draw();

            var square = (Polygon)new Square();
            square.Draw();
        }
    }

    public class Polygon
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing polygon");
        }
    }

    public class Triangle : Polygon
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing triangle");
        }
    }

    public class Square : Polygon
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Square");
        }
    }

}
