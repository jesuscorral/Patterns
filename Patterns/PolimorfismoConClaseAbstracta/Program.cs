using System;

namespace PolimorfismoConClaseAbstracta
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var polygon = (Polygon) new Triangle();

            polygon.Draw();
            polygon = new Square();
            polygon.Draw();
        }
    }

    // Una clase abstracta no se puede instanciar directamente
    public abstract class Polygon
    {
        public abstract void Draw();
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
