using System;

namespace WizardNinjaSamurai
{
    class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            Dexterity = 175;
        }

        public override int Attack(Human target)
        {
            Random rand = new Random();
            Console.WriteLine("------------------------>");
            int dmg = 5 * Dexterity;
            target.Health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            if(rand.NextDouble() < 0.2)
            {
                int ExtraDmg = 10;
                target.Health -= ExtraDmg;
                Console.WriteLine("10 BONUS DAMAGE!!!");
            }
                Console.WriteLine($"{target.Name} now has {target.Health} health");
            return target.Health;
        }

        public int Steal(Human target)
        {
            Console.WriteLine("------------------------>");
            int steal = 5;
            target.Health -= steal;
            Console.WriteLine($"{Name} stole {steal} health from {target.Name}!");
            Console.WriteLine($"{target.Name} now has {target.Health} health");
            return target.Health;
        }
    }
}