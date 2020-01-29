using System;

namespace exercise_51
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      PrintUntilNumber();

    }

    // Write your method here:
    public static void PrintUntilNumber(int number)
    {
      string userInput = Console.ReadLine();
      int number = Convert.ToInt32(userInput);
      int amount = 0;
      while (amount < number) 
      {
        Console.WriteLine(amount);
        amount = amount + 1;
      }
 
    }

  }
}
