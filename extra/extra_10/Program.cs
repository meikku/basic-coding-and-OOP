using System;

namespace extra_10
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Add your code here:
            int[] array = { 5, 1, 3, 4, 2 }; // taulukko, jossa nämä numerot
            PrintArrayInStars(array);

        }
        public static void PrintArrayInStars(int[] array)
        {
            int i = 0;
            while (i < array.Length) // käydään lista läpi 
            {
                int howMany = array[i];

                for (int round = 0; round < howMany; round++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
                i++;
            }

        }
    }
}
