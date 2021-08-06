using System;

namespace WizardNinjaSamurai
{
    public class Samurai : Human
    {
        public Samurai(string name) : base(name)
        {
            Name = name;
            Health = 200;
        }

        public override int Attack(Human target)
        {
            base.Attack(target);
            Console.WriteLine($"{target.Name} now has {target.Health} health");
            if (target.Health < 50)
            {
                target.Health = 0;
                Console.WriteLine($"FINISH HIM!!!");
                Console.WriteLine($"{target.Name} now has {target.Health} health and is dead.");
            }
            return target.Health;
        }
    }
}