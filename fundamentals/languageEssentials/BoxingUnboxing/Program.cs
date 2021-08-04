using System;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> weird = new List<object>();
            weird.Add(7);
            weird.Add(28);
            weird.Add(-1);
            weird.Add(true);
            weird.Add("chair");

            int total = 0;
            foreach (object see in weird) {
                if (see is string) 
                {
                    Console.WriteLine("string");
                }
                if (see is int) 
                {
                    Console.WriteLine("int");
                    total += (int)see;
                }
                if (see is bool) 
                {
                    Console.WriteLine("BOOLEAN");
                }
                Console.WriteLine(see);
            }
                Console.WriteLine(total);

            // UPDATED OPTION FOR PROBLEM -------------------------------------------------------------------------------------------------------------------->

            // Create an empty List of type object
            var boxed = new List<object>();

            // Add the following values to the list: 7, 28, -1, true, "chair"
            boxed.Add(7);
            boxed.Add(28);
            boxed.Add(-1);
            boxed.Add(true);
            boxed.Add("chair");

            // Loop through the list and print all values (Hint: Type Inference might help here!)
            int sum = 0;
            foreach(var item in boxed)
            {
                Console.WriteLine(item);
                if(item is int)
                {
                    Console.WriteLine("Looks like we have an int!");
                    sum += (int)item;
                    Console.WriteLine($"Current sum: {sum}");
                }
                // Add all values that are Int type together and output the sum
            }
        }
    }
}
