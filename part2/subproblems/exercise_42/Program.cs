using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {
      string userFirst = Console.ReadLine();
      int first = Convert.ToInt32(userFirst);

      string userSecond = Console.ReadLine();
      int second = Convert.ToInt32(userSecond);

      double squareRoot = Math.Sqrt(first + second);
      Console.WriteLine(squareRoot);
      // Write your code here:
    
    }
  }
}
