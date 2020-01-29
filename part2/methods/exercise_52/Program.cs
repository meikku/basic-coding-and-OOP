using System;

namespace exercise_52
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      PrintFromNumberToOne(5);
    }
    public static void PrintFromNumberToOne(int number)
    {
      while(number >= 1)
      {
        Console.WriteLine(number);
        number = number - 1;
      }
    }
    // Write your method here:

  }
}
