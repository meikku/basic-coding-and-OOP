using System;

namespace exercise_28
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("How old are you?");
      string userInput = Console.ReadLine();
      int age = Convert.ToInt32(userInput);

      if (age < 18)
      {
        Console.WriteLine("You're under age!");
      }
      else 
      {
        Console.WriteLine("You're an adult!");
      }

    }
  }
}
