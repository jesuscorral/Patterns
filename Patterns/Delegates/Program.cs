using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var del = new DelegateExample();
            del.Delegate();
            del.Action();
            del.Function();
            del.Predicate();
        }
    }
}