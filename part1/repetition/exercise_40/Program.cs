using System;

namespace exercise_40
{
  class Program
  {
    public static void Main(string[] args)
    {
      int sum = 0;
      int amount = 0;

      while(true)
      {  
        Console.WriteLine("Give a number:");
        string numberGiven = Console.ReadLine();
        int number = Convert.ToInt32(numberGiven);
      if (number == 0)
      {
        break;
      }
      else{
        sum = sum + number;
        amount = amount + 1;
      }
      }
    Console.WriteLine("Total sum of numbers: " + sum);
    Console.WriteLine("Total amount of numbers: " + amount);
      // Write your code here:
    }
  }
}
