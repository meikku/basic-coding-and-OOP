using System;

namespace exercise_50
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Call your method here:
      Console.WriteLine("How many times?");
      string userInput = Console.ReadLine();
      int number = Convert.ToInt32(userInput); 

      int amount = 0; 

      while (amount < number)
      {
        PrintPhrase();
        amount++;
      }
      
    }

    // Write your method here:
    public static void PrintPhrase() {
      Console.WriteLine("In a hole in the ground there lived a method");

    }
  }
}
