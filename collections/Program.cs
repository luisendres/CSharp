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
            List<string> iceCreamTwo =  new List<string>() {"Vanilla", "Chocolate", "Strawberry", "Sherbet,", "Mint"};
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
            // Console.WriteLine("Hello World!");
        }
    }
}
