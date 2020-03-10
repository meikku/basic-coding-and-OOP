using System;

namespace extra_06
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Add your code here:
            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            int sum = first + second;
            if (sum <= 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(Math.Sqrt(sum));
            }

        }
    }
}
