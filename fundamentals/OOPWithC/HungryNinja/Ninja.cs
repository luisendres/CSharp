using System;
using System.Collections.Generic;

namespace HungryNinja

{
    public class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
         
        // add a constructor
         public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }
        // add a public "getter" property called "IsFull"
        public bool IsFull
        {
            get
            {   
                return calorieIntake > 1200;
            }
        }
        // build out the Eat method
        public void Eat(Food item)
        {
            if (IsFull == false)
            {
                calorieIntake += item.Calories;
                FoodHistory.Add(item);
                Console.WriteLine($"Ninja ate {item.Name}");
            }
            if (IsFull == true)
            {
                Console.WriteLine("Ninja is too Full to eat!");
            }
        }
    }
}