using System;

namespace extra_02
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Add your code here:
            Console.WriteLine("Give three numbers:");
            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            int third = Convert.ToInt32(Console.ReadLine());

           
            int greatest = first;

            if (second > greatest)
            {
              greatest = second;
            }
            if (third > greatest)
            {
              greatest = third;
            }
            Console.WriteLine("Largest: " + greatest);
        }
    }
}
