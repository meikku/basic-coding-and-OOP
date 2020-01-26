using System;

namespace exercise_39
{
  class Program
  {
    public static void Main(string[] args)
    {
      int sum = 0;

      while(true)
      {
        
        Console.WriteLine("Give a number:");
        string numberGiven = Console.ReadLine();
        int number = Convert.ToInt32(numberGiven);

        if (number == 0)
        {
          break;
        }
        else 
        sum = sum + number;
      }
      Console.WriteLine("Total sum of numbers: " + sum);
      // Write your code here:
    }
  }
}
