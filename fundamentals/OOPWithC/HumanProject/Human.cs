namespace HumanProject
{
    public class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
         
        // add a public "getter" property to access health
        public int Health
        {
            //if the get{} are empty it will default to "this"/following
            get
            {
                return Health;
            }
            set 
            {
                Health = value;
            }
        }
        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;
        }
        
        // Add a constructor to assign custom values to all fields
        public Human(string name, int strength, int intelligence, int dexterity, int hp)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            health = hp;
        }
         
        // Build Attack method
        public int Attack(Human target)
        {
            int damage = 5 * Strength;
            Health -= damage;
            return health;
        }
    }
}