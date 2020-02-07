using System;
using System.Collections.Generic;

namespace exercise_80
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 5, 1, 3, 4, 2 };
            int sum = SumOfNumbersInArray(numbers);
            Console.WriteLine(sum);

        }

        public static int SumOfNumbersInArray(int[] numbers)
        {

            int index = 0;
            int sum = 0;
            while (index < numbers.Length)
            {
              sum = sum + numbers[index];
              index++;
            }
            return sum;


        }

    }
}


