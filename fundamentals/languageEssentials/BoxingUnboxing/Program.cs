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

            int sum = 0;
            foreach (object see in weird) {
                if (see is string) 
                {
                    Console.WriteLine("string");
                }
                if (see is int) 
                {
                    Console.WriteLine("int");
                    sum += (int)see;
                }
                if (see is bool) 
                {
                    Console.WriteLine("BOOLEAN");
                }
                Console.WriteLine(see);
            }
                Console.WriteLine(sum);
        }
    }
}
