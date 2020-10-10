using System;

namespace StrategyPattern
{
    public class Puncher : IFigthingBehaviour
    {
        public void Fight()
        {
            Console.WriteLine($"Toma puñetazo!");
        }
    }
}
