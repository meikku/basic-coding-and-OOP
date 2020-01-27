using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Where to?");
      string userInput = Console.ReadLine();
      int end = Convert.ToInt32(userInput);
     

      Console.WriteLine("Where from?");
      string secondInput = Console.ReadLine();
      int start = Convert.ToInt32(secondInput);

      while (start <= end)
      {
        Console.WriteLine(start);
        start = start + 1;
      }
    }
  }
}
