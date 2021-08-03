using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        public static int[] RandomArray()
        {
            int[] array = new int[10];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(5,25);
                Console.WriteLine(array[i]);
            }
            return array;
        }
        public static int TossCoin()
        {
            Random rand = new Random();
            Console.WriteLine("Tossing a Coin!");
            int heads = 0;
            if (rand.Next(2) == 1)
            {
                Console.WriteLine("Heads!");
                heads++;
            }
            else {
                Console.WriteLine("Tails!");
            }
            return heads;
        }
        public static double TossMultipleCoins(int num)
        {
            int results = 0;
            for (int i = 0; i <= num; i++)
            {
                TossCoin();
                if (TossCoin() == 1) {
                    results++;
                }
            }
            double ratio = (double)results/num;
            return ratio;
        }
        public static List<string> Names()
        {
            List<string> names = new List<string>()
            {
                "Todd", "Tiffany", "Charlie", "Geneva", "Sydney"
            };

            List<string> newList = new List<string>();
            Random rand = new Random();
            for (int i = names.Count - 1; i >= 0; i--) {
                int tempIndex= rand.Next(i + 1);
                string tempName = names[i];
                names[i] = names[tempIndex];
                names[tempIndex] = tempName;
                Console.WriteLine(names[i]);
            }
                Console.WriteLine();

            foreach(var name in names)
            {
            int length = 0;
            length = name.Length;

                if (length > 5) 
                {
                    newList.Add(name);
                }
            }

            return newList;
        }
        static void Main(string[] args)
        {
            RandomArray();
            TossCoin();
            TossMultipleCoins(5);
            Console.WriteLine(TossMultipleCoins(5));
            foreach(var name in Names())
                Console.WriteLine(name);
        }
    }
}
