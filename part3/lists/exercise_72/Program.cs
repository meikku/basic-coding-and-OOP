using System;
using System.Collections.Generic;

namespace exercise_72
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 9999)
                {
                    break;
                }
                numbers.Add(input);
            }

            int smallest = 9999;
            int index = 0; 

            while (index < numbers.Count)
            {
                if (numbers[index] < smallest)
                {
                    smallest = (numbers[index]);
                }
                index++; 
            }

            Console.WriteLine("Smallest number: " + smallest);
            
            int i = 0;
            while (i < numbers.Count)
            {
                if (numbers[i] == smallest)
                {
                    Console.WriteLine("Found at index: " + i);
                }
                i++;
            }
            
           
            
        }
    }
}
