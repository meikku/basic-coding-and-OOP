using System;

namespace exercise_33
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
    Console.WriteLine("Give the first string:");
    string thoughtForToday = Console.ReadLine();

    Console.WriteLine("Give the second string:");
    string kindOfBoredWithUserInput = Console.ReadLine();

    if (thoughtForToday == kindOfBoredWithUserInput)
    { Console.WriteLine("Echo!");
    
    } else
    {
      Console.WriteLine("Nope!");
    }
    }
  }
}
