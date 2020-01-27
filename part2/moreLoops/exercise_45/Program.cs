using System;

namespace exercise_45
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      string userInput = Console.ReadLine();
      int number = Convert.ToInt32(userInput);

      int amount = 0;
      while (amount <= number)
      {
        Console.WriteLine(amount);
        amount = amount +1;
      }
    }
  }
}
