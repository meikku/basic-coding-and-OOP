using System;

namespace exercise_19
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give the first number!");
      string userFirst = Console.ReadLine();
      int first = Convert.ToInt32(userFirst);

      Console.WriteLine("Give the second number!");
      string userSecond = Console.ReadLine();
      int second = Convert.ToInt32(userSecond);

      int sum = first + second; 

      Console.WriteLine(first + " + " + second + " = " + sum);

      // Write your code here:

    }
  }
}
