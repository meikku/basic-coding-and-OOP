using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a string:");
      string text = Console.ReadLine();
      Console.WriteLine("Give an integer:");
      string number = Console.ReadLine();
      int userNumber = Convert.ToInt32(number);
      Console.WriteLine("Give a double:");
      string anotherNumber = Console.ReadLine();
      double userDecimal = Convert.ToDouble(anotherNumber);
      Console.WriteLine("Give a boolean:");
      string truth = Console.ReadLine();
      bool userBoolean = System.Convert.ToBoolean(truth);

      Console.WriteLine("Your string: " + text);
      Console.WriteLine("Your integer: " + userNumber);
      Console.WriteLine("Your double: " + userDecimal);
      Console.WriteLine("Your boolean: " + userBoolean);

      // Write your code here:

    }
  }
}
