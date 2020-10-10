using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var dwarf = new Dwarf(new Kicker());
            var boxer = new Boxer(new Puncher());
            var zombie = new Zombie(new Biter());
            var kangaroo = new Kangaroo(new Kicker());

            var warriors = new List<Warrior> { dwarf, boxer, zombie, kangaroo };

            foreach (var warrior in warriors)
            {
                Console.WriteLine($"Aparece un guerrero {warrior.GetType().Name}");
                warrior.ShowYourMove();
                Console.WriteLine();
            }

            // Cambia el comportamiento de cada guerrero en tiempo de ejecucion;
            dwarf.ChangeBehaviour(new Biter());
            boxer.ChangeBehaviour(new Biter());

            Console.WriteLine("Apocalipsis Zombie");

            // Apocalipsis Zombie
            foreach (var warrior in warriors) {
                Console.WriteLine($"Aparece un guerrero {warrior.GetType().Name} y ahora...");
                warrior.ShowYourMove();
                Console.WriteLine();
            }
        }
    }

    public class Warrior
    {
        private IFigthingBehaviour _figthingBehaviour;

        protected Warrior(IFigthingBehaviour figthingBehaviour)
        {
            _figthingBehaviour = figthingBehaviour;
        }

        public void ShowYourMove()
        {
            _figthingBehaviour.Fight();
        }

        public void ChangeBehaviour(IFigthingBehaviour figthingBehaviour)
        {
            _figthingBehaviour = figthingBehaviour;
        }
    }

    public class Dwarf : Warrior
    {
        public Dwarf(IFigthingBehaviour figthingBehaviour) : base(figthingBehaviour)
        {
        }
    }

    public class Boxer : Warrior
    {
        public Boxer(IFigthingBehaviour figthingBehaviour) : base(figthingBehaviour)
        {
        }
    }

    public class Zombie : Warrior
    {
        public Zombie(IFigthingBehaviour figthingBehaviour) : base(figthingBehaviour)
        {
        }
    }

    public class Kangaroo : Warrior
    {
        public Kangaroo(IFigthingBehaviour figthingBehaviour) : base(figthingBehaviour)
        {
        }
    }


}