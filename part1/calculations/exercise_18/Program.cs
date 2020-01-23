using System;

namespace exercise_18
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

      Console.WriteLine("Give the third number!");
      string userThird = Console.ReadLine();
      int third = Convert.ToInt32(userThird);
      int sum = first + second + third; 

      Console.WriteLine("The sum is " + sum);
      

    }
  }
}
