using System;

namespace exercise_21
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give the first number!");
      string eka = Console.ReadLine();
      int first = Convert.ToInt32(eka);

      Console.WriteLine("Give the second number!");
      string toka = Console.ReadLine();
      int second = Convert.ToInt32(toka);

      double average = (first + second) / 2.0;

      Console.WriteLine("The average is " + average);


      // Write your code here:

    }
  }
}
