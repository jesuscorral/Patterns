using System;

namespace Delegates
{
    public class DelegateExample
    {
        public delegate void ImprimirDelegado(string s);

        Action<int, int, int> Check = DoWorkWithThreeParameters;
        Action<int> PrintAge = (age) => Console.WriteLine($"La edad es: {age}");

        Func<int, int, int> Multiplication = (v1, v2) => v1 * v2;

        Predicate<int> IsLegal = (age) => age >= 18;

        public DelegateExample()
        { }

        public void Delegate()
        {
            var d = new ImprimirDelegado(Imprime);
            d("Esto es lo que hay que imprimir");
        }

        public void Action()
        {
            Check(10, 15, 23);
            PrintAge(52);
        }

        public static void DoWorkWithThreeParameters(int arg1, int arg2, int arg3)
        {
            Console.WriteLine(arg1 + "-" + arg2 + "-" + arg3);
        }

        public void Function()
        {
            int valor = Multiplication(3, 2);
            Console.WriteLine($"El resultado es {valor}");
        }

        public void Predicate()
        {
            Console.WriteLine($"Es mayor de edad?: {IsLegal(18)}");
        }

        private void Imprime(string s)
        {
            Console.WriteLine(s);
        }
    }
}
