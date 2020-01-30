using System;

namespace exercise_58
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = Smallest(2, 7);
      Console.WriteLine("Smallest: " + answer);
    }
      public static int Smallest (int number1, int number2)
      {
        int smaller = number1;
        if (number2 < number1)
        {
          smaller = number2;
        }
        return smaller;
      }
    // Write your method here:
    
  }
}
