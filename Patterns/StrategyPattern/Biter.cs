using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Biter : IFigthingBehaviour
    {
        public void Fight()
        {
            Console.WriteLine($"Toma mordisco!");
        }
    }
}
