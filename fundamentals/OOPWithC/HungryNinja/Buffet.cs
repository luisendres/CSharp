using System;
using System.Collections.Generic;

namespace HungryNinja
{
    public class Buffet
    {
        public List<Food> Menu;
         
        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Example", 1000, false, false),
                new Food("Burger", 2000, false, false),
                new Food("Candy", 3000, false, true),
                new Food("Pepper", 500, true, false),
                new Food("Mango", 700, false, true),
                new Food("Cracker", 100, false, false),
                new Food("Water", 10, false, false)
            };
        }

        public Food Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(Menu.Count)];
        }
    }
}