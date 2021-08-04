using System;

namespace Basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumbers();
            PrintOdds();
            PrintSum();
            int[] arrayBoom = {1,2,3,4,5,7,11, -100, 0, 1,};
            int[] negativeArray = {-3, -5, -7, -2};
            int[] averageArray = {2,10,2,1};
            LoopArray(arrayBoom);
            Console.WriteLine(FindMax(negativeArray));
            GetAverage(averageArray);

            int[] oddNums = OddArray();
            Console.WriteLine(String.Join(",", oddNums));
            foreach (int number in OddArray())
            {
                Console.WriteLine(number);    
            }

            int[] greaterArray = {1, 3, 5, 7};
            Console.WriteLine(GreaterThanY(greaterArray,3));

            int[] squareArray = {1,5,10,-10};
            SquareArrayValues(squareArray);

            int[] noNegativesArray = {1, 5, 10, -2};
            EliminateNegatives(noNegativesArray);

            int[] maxMinAvgArray = {1, 5, 10, -2};
            MinMaxAverage(maxMinAvgArray);

            int[] shiftArray = {1, 5, 10, 7, -2};
            ShiftValues(shiftArray);

            object[] numsAndWords = NumToString(new int[5] {1,-10,5,6,-1});
            Console.WriteLine(String.Join(",", numsAndWords));
            int[] intArray = {-1, -3, 2};
            foreach (object number in NumToString(intArray))
            {
                Console.WriteLine(number);    
            }
        }
// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------->
        // Print 1-255
        public static void PrintNumbers()
        {
            // Print all of the integers from 1 to 255.
            for (int i = 1; i < 256; i++)
            {
                Console.WriteLine(i);
            }
        }
// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------->
        // Print odd numbers between 1-255
        public static void PrintOdds()
        {
            // Print all of the odd inttegers from 1 to 255.
            for (int i = 1; i < 256; i++)
            {
                if( i % 2 != 0)
                {
                Console.WriteLine(i);
                }
            }
        }
// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------->
        // Print Sum
        public static void PrintSum()
        {
            // Print all of the numbers from 0 to 255, 
            // but this time, also print the sum as you go. 
            // For example, your output should be something like this:
            int sum = 0;
            for (int i = 0; i < 256; i++)
            {
                sum += i;
                Console.WriteLine($"New number: {i} Sum: {sum}");
            }
            // New number: 0 Sum: 0
            // New number: 1 Sum: 1
            // New Number: 2 Sum: 3
        }
// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------->
        // Iterating through an Array
        public static void LoopArray(int[] numbers)
        {
            // Write a function that would iterate through each item of the given integer array and 
            // print each value to the console. 
            foreach (int integerValue in numbers)
            {
                Console.WriteLine(integerValue);
            }
        }
// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------->
        // Find Max
        public static int FindMax(int[] numbers)
        {
            // Write a function that takes an integer array and prints and returns the maximum value in the array. 
            // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
            // or even a mix of positive numbers, negative numbers and zero.
            int max = numbers[0];
            foreach (int i in numbers) 
            {
                if (i > max) 
                {
                    max = i;
                }
            }
            return max;
        }
// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------->
        // Get Average
        public static void GetAverage(int[] numbers)
        {
            // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
            // For example, with an array [2, 10, 3], your program should write 5 to the console.
            float avg = 0;
            foreach (int a in numbers)
            {
                avg += a;
            }
            avg /= numbers.Length;
            Console.WriteLine(avg);
        }
// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------->
        // Array with Odd Numbers
        public static int[] OddArray()
        {
            // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255.
            // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
            double size = Math.Ceiling(255.0/2);
            int length = (int)size;
            int[] oddNumsArray = new int[length];
            int i = 0;

            for (int oddNumber = 1; oddNumber < 256; oddNumber += 2)
            {
                oddNumsArray[i] = oddNumber;
                i++;
            }

            return oddNumsArray;
        }
// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------->
        // Greater than Y
        public static int GreaterThanY(int[] numbers, int y)
        {
            // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
            // That are greater than the "y" value. 
            // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
            // (since there are two values in the array that are greater than 3).
            int greater = 0;
            foreach (int num in numbers)
            {
                if(num > y)
                {
                    greater++;
                }
            }
            return greater;
        }
// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------->
        // Square the Values
        public static void SquareArrayValues(int[] numbers)
        {
            // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
            // For example, [1,5,10,-10] should become [1,25,100,100]
            for(int i = 0; i < numbers.Length; i++)
            {
                int multiply = numbers[i] * numbers[i];
                numbers[i] = multiply;
            }
            Console.WriteLine(String.Join(",", numbers));
        }
// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------->
        // Eliminate Negative Numbers
        public static void EliminateNegatives(int[] numbers)
        {
            // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
            // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
            }
            Console.WriteLine(String.Join(",", numbers));
        }
// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------->
        // Min, Max, and Average
        public static void MinMaxAverage(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
            // the minimum value in the array, and the average of the values in the array.
            int max = numbers[0];
            int min = numbers[0];
            float average = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }

                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                
                average += numbers[i];
            }
            average /= numbers.Length;
            Console.WriteLine($"Max: {max}, Min: {min}, Average: {average}");
        }
// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------->
        // Shifting the values in an array
        public static void ShiftValues(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, 7, -2], 
            // Write a function that shifts each number by one to the front and adds '0' to the end. 
            // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
            // it should become [5, 10, 7, -2, 0].
            for(int i = 0; i < numbers.Length; i++)
            {
                if(i == numbers.Length - 1)
                {
                    numbers[i] = 0;
                }
                else
                {
                numbers[i] = numbers[i + 1];
                }
            }
            Console.WriteLine(String.Join(",", numbers));
        }
// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------->
        // Number to String
        public static object[] NumToString(int[] numbers)
        {
            // Write a function that takes an integer array and returns an object array 
            // that replaces any negative number with the string 'Dojo'.
            // For example, if array "numbers" is initially [-1, -3, 2] 
            // your function should return an array with values ['Dojo', 'Dojo', 2].
            object[] numsToStrings = new object[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    numsToStrings[i] = "Dojo";
                }
                else
                {
                    numsToStrings[i] = numbers[i];
                }
            }
            return numsToStrings;
        }

    }
}
