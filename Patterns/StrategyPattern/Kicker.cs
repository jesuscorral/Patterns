using System;

namespace StrategyPattern
{
    public class Kicker : IFigthingBehaviour
    {
        public void Fight()
        {
            Console.WriteLine($"Toma patada!");
        }
    }
}
