using System;

namespace exercise_29
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give the first number!");
      string userFirst = Console.ReadLine();
      int first = Convert.ToInt32(userFirst);

      Console.WriteLine("Give the second number!");
      string userSecond = Console.ReadLine();
      int second = Convert.ToInt32(userSecond);

      if (first > second)
      {Console.WriteLine("The larger number is " + first + "!");

      }
      else if (first == second)
      {Console.WriteLine("They are equal!");

      }
      else 
      { Console.WriteLine("The larger number is " + second + "!");
      }




    }
  }
}
