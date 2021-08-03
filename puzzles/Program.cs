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

        // WITH UPDATED OPTIONAL WAYS----------------------------------------------------------------------------------------------->
        
        // static void Main(string[] args)
        // {
        //     var result = Names();
        

        // }
        // public static List<string> Names()
        // {
        //     // Create an list with the values: Todd, Tiffany, Charlie, Geneva, Sydney
        //     List<string> names = new List<string>()
        //     {
        //         "Todd", "Tiffany", "Charlie", "Geneva", "Sydney"
        //     };

        //     Random rand = new Random();

        //     // shuffle names
        //     for(var i=0; i<names.Count/2; i++)
        //     {
        //         // swap names[i] with names[randomIndex]
        //         int randomIndex = rand.Next(names.Count);
        //         string temp = names[randomIndex];
        //         names[randomIndex] = names[i];
        //         names[i] = temp;
        //     }

        //     // print new order of names
        //     foreach(var name in names)
        //     {
        //         Console.WriteLine(name);
        //     }

        //     // remove names not larger than 5 characters
        //     for(var i = 0; i < names.Count; i++)
        //     {
        //         if(names[i].Length <= 5)
        //             names.RemoveAt(i);
        //     }

        //     return names;
        // }
        // public static double TossMultiple(int numTimes)
        // {
        //     Random rand = new Random();
        //     int numHeads = 0;
        //     for(var toss = 0; toss < numTimes; toss++)
        //     {
        //         if(rand.Next(2) == 0)
        //             numHeads++;
        //     }
        //     return (double)numHeads/numTimes;
        // }
        // public static string TossCoin()
        // {
        //     Random rand = new Random();
        //     string result;
        
        //     if(rand.Next(2) == 0)
        //         result = "Heads";
        //     else
        //         result = "Tails";

        //     Console.WriteLine($"The result is: {result}");
        //     return result;
        // }
        // public static int[] RandomArray()
        // {
        //     Random rand = new Random();
        //     int[] nums = new int[10];

        //     for(var i=0; i<nums.Length; i++)
        //         nums[i] = rand.Next(5, 26);

        //     // Find Min, Max, Sum
        //     int min = Int32.MaxValue;
        //     int max = Int32.MinValue;
        //     int sum = 0;

        //     foreach(var num in nums)
        //     {
        //         sum += num;
        //         if(min > num)
        //             min = num;
        //         if(max < num)
        //             max = num;
        //     }
        //     Console.WriteLine($"Min: {min}, Max: {max}, Sum {sum}");
        //     return nums;
        // }

    }
}
