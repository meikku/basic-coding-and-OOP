using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give numbers:");
      int sum = 0;
      int round = 0;
      int even = 0;

      while (true)
      {
        string userInput = Console.ReadLine();
        int number = Convert.ToInt32(userInput);

        if (number % 2 == 0)
        { 
        even = even +1; 
        }

        if (number == -1)
        {
          break;
          
        } else
        {
          sum = sum + number;
          round = round +1; 
          

        }
        
      }
      Console.WriteLine("Thx! Bye!");
      Console.WriteLine("Sum: " + sum);
      Console.WriteLine("Numbers: " + round);
      double average  = 1.0 * sum / round;
      Console.WriteLine("Average: " + average);
      int odd = round - even; 
      Console.WriteLine("Even: " + even);
      Console.WriteLine("Odd: " + odd);


    }
  }
}
