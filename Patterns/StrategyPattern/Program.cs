using System;
using System.Collections.Generic;
using System.IO;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var dwarf = new Dwarf();
            var boxer = new Boxer();
            var zombie = new Zombie();
            var kangaroo = new Kangaroo();

            var warriors = new List<Warrior> { dwarf, boxer, zombie, kangaroo };

            foreach (var warrior in warriors)
            {
                Console.WriteLine($"Aparece un guerrero {warrior.GetType().Name}");
                warrior.ShowYourMove();
                Console.WriteLine();
            }
        }
    }

    public class Warrior
    {
        private readonly IFigthingBehaviour _figthingBehaviour;

        protected Warrior(IFigthingBehaviour figthingBehaviour)
        {
            _figthingBehaviour = figthingBehaviour;
        }

        public void ShowYourMove()
        {
            _figthingBehaviour.Fight();
        }
    }

    public class Dwarf : Warrior
    {
        protected Dwarf(IFigthingBehaviour figthingBehaviour) : base(figthingBehaviour)
        {
           
        }
    }

    public class Boxer : Warrior
    {
        protected Boxer(IFigthingBehaviour figthingBehaviour) : base(figthingBehaviour)
        {
        }
    }

    public class Zombie : Warrior
    {
        protected Zombie(IFigthingBehaviour figthingBehaviour) : base(figthingBehaviour)
        {
        }
    }

    public class Kangaroo : Warrior
    {
        protected Kangaroo(IFigthingBehaviour figthingBehaviour) : base(figthingBehaviour)
        {
        }
    }
}
