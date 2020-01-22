using System;

namespace exercise_22
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

      Console.WriteLine("Give the third number!");
      string userThird = Console.ReadLine();
      int third = Convert.ToInt32(userThird);

      double average = (first + second + third) / 3.0;

      Console.WriteLine("The average is " + average);


      // Write your code here:

    }
  }
}
