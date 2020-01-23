using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("How many days?");
      string days = Console.ReadLine();
      int amountOfDays = Convert.ToInt32(days);
      int seconds = 24 * 60 * 60 * amountOfDays;
      Console.WriteLine(seconds);

            // Write your code here:

    }
  }
}
