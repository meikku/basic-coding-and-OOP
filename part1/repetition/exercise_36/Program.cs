using System;

namespace exercise_36
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
    while(true)
    {
      Console.WriteLine("Give a number:");
      string numberGiven = Console.ReadLine();
      int number = Convert.ToInt32(numberGiven);

      if (number == 0)
      {
        break;
      }
      else if (number <= 0)
      {
        Console.WriteLine("That is negative");
      }
      else
      Console.WriteLine(number * number);
    }
    
    }
  }
}
