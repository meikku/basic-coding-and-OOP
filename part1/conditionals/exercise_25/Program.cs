using System;

namespace exercise_25
{
  class Program
  {
    public static void Main(string[] args)
    { 
      Console.WriteLine("Give a number:");
      string userInput = Console.ReadLine();
      int number = Convert.ToInt32(userInput);

      if (number == 1984)
      {
        Console.WriteLine("Orwell");
      }
      // Write your code here:

    }
  }
}
