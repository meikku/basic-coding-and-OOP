using System;

namespace exercise_59
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = Greatest(18, 7, 2);
      Console.WriteLine("Greatest: " + answer);
    }

    // Write your method here:
      public static int Greatest(int number1, int number2, int number3)
      {
        int answer = number1;
        if (number2 > answer)
        { 
          answer = number2;
        }
        if (number3 > answer)
        {
          answer = number3;
        }
        return answer;
      }
  }
}
