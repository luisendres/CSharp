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
                return health;
            }
            set 
            {
                health = value;
            }
        }
        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
        
        // Add a constructor to assign custom values to all fields
        public Human(string name, int str, int intel, int dex, int hp)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = hp;
        }
         
        // Build Attack method
        public int Attack(Human target)
        {
            // create integer variable to hold the amount of damage the attack will do 
            int dmg = 5 * Strength;
            target.health -= dmg;
            // This next line of code would display who attacked who and for how much damage but can't display inn this form
            // Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.health;
        }
    }
}