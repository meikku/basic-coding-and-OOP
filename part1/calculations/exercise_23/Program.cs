using System;

namespace exercise_23
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
      int subtraction = first - second; 
      int multiplication = first * second;
      double division = 1.0 * first / second;

      Console.WriteLine(first + " + " + second + " = " + sum);
      Console.WriteLine(first + " - " + second + " = " + subtraction);
      Console.WriteLine(first + " * " + second + " = " + multiplication);
      Console.WriteLine(first + " / " + second + " = " + division);



      // Write your code here:

    }
  }
}
