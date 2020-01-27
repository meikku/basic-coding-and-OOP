using System;

namespace exercise_44
{
  class Program
  {
    public static void Main(string[] args)
    {
      string userFirst = Console.ReadLine();
      int first = Convert.ToInt32(userFirst);

      string userSecond = Console.ReadLine();
      int second = Convert.ToInt32(userSecond);

      if (first < second)
      {
        Console.WriteLine(first + " is less than " + second + ".");
      }
      else if (first > second)
      {
        Console.WriteLine(first + " is greater than " + second + ".");
      }
      else if (first == second)
      {
        Console.WriteLine(first + " is equal to " + second + ".");
      }
      // Write your code here:

    }
  }
}
