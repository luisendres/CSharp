using System;

namespace WizardNinjaSamurai
{
    public class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            Name = name;
            Health = 50;
            Intelligence = 25;
        }

        public override int Attack(Human target)
        {
            Console.WriteLine("------------------------>");
            int dmg = 5 * Intelligence;
            target.Health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            Console.WriteLine($"{target.Name} now has {target.Health} health");
            this.Health += dmg;
            Console.WriteLine($"{this.Name} healed by {dmg}. Now they have a total health of {this.Health}.");
            return target.Health;
        }

        public int Heal(Human target)
        {
            Console.WriteLine("------------------------>");
            int heal = 10 * Intelligence;
            target.Health += heal;
            Console.WriteLine($"{Name} Healed {target.Name} for {heal} health.");
            Console.WriteLine($"{target.Name} now has {target.Health} health");
            return target.Health;
        }
    }
}