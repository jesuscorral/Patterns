using System;

namespace PolimorfismoConInterfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            var drawable = (IDrawable) new Triangle();
            drawable.Draw();
            drawable = new Square();
            drawable.Draw();

        }
    }

    public interface IDrawable
    {
        void Draw();
    }

    public class Triangle : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("Drawing triangle");
        }
    }

    public class Square : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Square");
        }
    }
}
