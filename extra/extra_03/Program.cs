using System;

namespace extra_03
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many numbers?");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give " + input + " numbers:");

            int sum = 0;
            int total = 1;
            for (int i = 0; i < input; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                sum = sum + number;
                total = total * number;
            }

            // Add your code here:

            Console.WriteLine("Their sum: " + sum);
            Console.WriteLine("Their total: " + total);
            Console.WriteLine("Their average: " + sum / input);


        }
    }
}
