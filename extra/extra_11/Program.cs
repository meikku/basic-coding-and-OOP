using System;

namespace extra_11
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Add your code here:
            Console.WriteLine("Give a sentence:");
            string input = Console.ReadLine();
            string[] pieces = input.Split(" ");

            foreach (string line in pieces)
            {
                Console.WriteLine(line);
            }


        }
    }
}
