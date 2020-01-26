using System;

namespace exercise_38
{
  class Program
  {
    public static void Main(string[] args)
    {
      int amount = 0;
      while (true)
      {
        Console.WriteLine("Give a number:");
        string numberGiven = Console.ReadLine();
        int number = Convert.ToInt32(numberGiven);

        if (number == 0)
        {break;
        }
        else if (number < 0)
        {
          amount = amount++;
        }
      }
      Console.WriteLine("Total amount of negative numbers: " + amount);
      // Write your code here:

    }
  }
}
