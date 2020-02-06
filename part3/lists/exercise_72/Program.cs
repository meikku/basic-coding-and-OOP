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
            int whichIndex = 0;

            while (index < numbers.Count)
            {
                if (numbers[index] < smallest)
                {
                    smallest = numbers[index];

                }

                index++;
                if (numbers.Contains(smallest))
                { 

                }

            }
            Console.WriteLine("Smallest number: " + smallest);
            int whichIndex = smallest;

            while (index < numbers.Count)
            {
               if ((numbers[index]== 
               {
                 Console.WriteLine("Found at index: " + whichIndex); 
               }

             
            }


           
           
        }
    }
}
