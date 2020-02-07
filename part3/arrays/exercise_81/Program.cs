using System;
using System.Collections.Generic;

namespace exercise_81
{
    class Program
    {
        public static void Main(string[] args)
        {
            // You can test your method here
            int[] array = { 5, 1, 3, 4, 2 };
            PrintNeatly(array);
        }

        public static void PrintNeatly(int[] array)
        {
            int index = 0;
            while (index < (array.Length - 1))
            {
                Console.Write(array[index]);
              
                Console.Write(", ");
                index = index + 1;
            }
            Console.WriteLine(array[index]);
            return;

        }
    }
}

