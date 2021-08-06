using System;

namespace WizardNinjaSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard Merlin = new Wizard("Merlin");
            Wizard Gandalf = new Wizard("Gandalf");
            Ninja Scorpion = new Ninja("Scorpion");
            Samurai Jack = new Samurai("Jack");
            
            Gandalf.GetInfo();
            Merlin.GetInfo();
            Scorpion.GetInfo();
            Jack.GetInfo();

            Gandalf.Heal(Jack);
            Merlin.Heal(Jack);
            Jack.Attack(Merlin);
            Scorpion.Steal(Gandalf);
            Scorpion.Attack(Jack);
            Gandalf.Attack(Scorpion);
            // Merlin.Heal(Merlin);
        }
    }
}
