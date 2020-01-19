using System;

namespace exercise_12
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
    Console.WriteLine("Give a number!");
    string luku = Console.ReadLine();
    int userInput = Convert.ToInt32(luku);

    Console.WriteLine("You gave " + userInput);

    }
  }
}
