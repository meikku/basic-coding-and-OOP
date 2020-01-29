using System;

namespace exercise_51
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      
    
      PrintUntilNumber(5);

    }

    // Write your method here:
    public static void PrintUntilNumber(int number)
    {
    
      int amount = 1;
      while (amount <= number) 
      {
        Console.WriteLine(amount);
        amount = amount + 1;
      }
 
    }

  }
}
