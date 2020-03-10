using System;

namespace extra_07
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Add your code here:
            int sum = 0;
            Console.WriteLine("Give integers, 'end' quits:");
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                else
                {
                    int number = Convert.ToInt32(input);

                    sum = sum + number;
                }

            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}
