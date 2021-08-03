using System;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3 basic arrays -------------------------------------------------------------------------------------->
            // array that holds the values 0 through 9.
            // if you just state the length of the array it sets every value to 0 by default.
            int[] arrayNum = {0,1,2,3,4,5,6,7,8,9};
            // array that holds the names "Tim", "Martin", "Nikki", & " Sara".
            string[] arryName = {"Tim", "Martin", "Nikki", "Sara"};
            // array with the length of 10 and alternates between true and false values, starting with true
            // you do not need to initialize a value to false, it's flase but default
            // So what is a better way to write it out?
            bool[] arrayBool = {true, false, true, false, true, false, true, false, true, false};
            // Possibly this way?
            bool[] arrayBoolTwo = new bool[10];
            arrayBoolTwo[0] = true;
            arrayBoolTwo[2] = true;
            arrayBoolTwo[4] = true;
            // etc...

            // 3 basic arrays UPDATED-------------------------------------------------------------------------------------->
            // Create an array to hold integer values 0 through 9
            int[] numbers = new int[10];
            for(var i = 0; i < numbers.Length; i++)
                numbers[i] = i;
            // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] names = new string[]
            {
                "Tim", "Martin", "Nikki", "Sara"
            };
            // Create an array of length 10 that alternates between true and false values, starting with true
            bool[] boolies = new bool[10];
            for(var i = 0; i < boolies.Length; i++)
                boolies[i] = i % 2 == 0;

            // List of flavors -------------------------------------------------------------------------------------->
            // List of 5 different flavored Ice Cream.
            // Creating List  with the .add method.
            List<string> iceCream = new List<string>();
            iceCream.Add("Vanilla");
            iceCream.Add("Chocolate");
            iceCream.Add("Strawberry");
            iceCream.Add("Sherbet");
            iceCream.Add("Mint");
            // another way to initialize the (string)List.
            List<string> iceCreamTwo =  new List<string>() 
            {
                "Vanilla", "Chocolate", "Strawberry", "Sherbet,", "Mint"
            };
            // output length of the Ice Cream array.
            int length = iceCream.Count;
            int lengthTwo = iceCreamTwo.Count;
            // outputting the length with a for loop
            for (var i = 0; i < iceCream.Count; i++)
            {
                Console.WriteLine("-" + iceCream[i] + " " + i);
            }
            // remove the third flavor in the List by value
            iceCream.Remove("Strawberry");
            // removing the third flavor by the index
            iceCreamTwo.RemoveAt(2);
            // output the List to show the removed value with a "foreach" loop
            foreach (string flavor in iceCream)
            {
                Console.WriteLine("-" + flavor);
            }

            // List of flavors UPDATED-------------------------------------------------------------------------------------->
            List<string> flavors = new List<string>()
            {
                "Chocolate", "Strawberry", "Vanilla Bean", "Cookie Dough", "Dolce de Leche"
            };
            // Output the length of this list after building it
            Console.WriteLine($"Number of Flavors: {flavors.Count}");
            // Output the third flavor in the list, then remove this value
            Console.WriteLine($"Third Flavor: {flavors[2]}");
            flavors.RemoveAt(2);
            // Output the new length of the list (It should just be one fewer!)
            Console.WriteLine($"Number of Flavors: {flavors.Count}");

            // User info dictionary -------------------------------------------------------------------------------------->
            // create a dictionary that will store both keys and values as strings
            Dictionary<string,string> user = new Dictionary<string, string>();
            // add key/values to the dictionary
            // each key is a name from names array
            // each value id a randomly selected flavor from flavor list
            // create a random object
            Random rand = new Random();
            // add users and ice cream flavor
            user.Add("Tim", iceCream[rand.Next(0,3)]);
            user.Add("Martin", iceCream[rand.Next(0,3)]);
            user.Add("Nikki", iceCream[rand.Next(0,3)]);
            user.Add("Sara", iceCream[rand.Next(0,3)]);
            // loop through dictionary and print each user's name and their ice cream flavor
            foreach (var entry in user)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }

            // User info dictionary UPDATED-------------------------------------------------------------------------------------->
            // Create a dictionary that will store both string keys as well as string values
            Dictionary<string, string> preferences = new Dictionary<string,string>();
            // For each name in the array of names you made previously, add it as a new key in this dictionary with value null
            foreach(var name in names)
                preferences.Add(name, null);
            // For each name key, select a random flavor from the flavor list above and store it as the value
            Random rand = new Random();
            foreach(var name in names)
                preferences[name] = (flavors[rand.Next(flavors.Count)]);
            // Loop through the dictionary and print out each user's name and their associated ice cream flavor
            foreach(var kp in preferences)
                Console.WriteLine($"{kp.Key} prefers {kp.Value}");
        }
    }
}
