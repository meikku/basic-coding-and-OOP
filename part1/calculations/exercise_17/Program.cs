using System;

namespace exercise_17
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give the first number!");
      string userInput = Console.ReadLine();
      int first = System.Convert.ToInt32(userInput);
      Console.WriteLine("Give the second number!");
      string userInput2 = Console.ReadLine();
      int second = System.Convert.ToInt32(userInput2);

      Console.WriteLine("The sum is " + (first + second));

      // Write your code here:

    }
  }
}
