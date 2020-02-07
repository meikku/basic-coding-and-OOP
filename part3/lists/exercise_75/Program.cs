using System;
using System.Collections.Generic;

namespace exercise_75
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Example method calls for testing your method.
      // List<int> numbers = new List<int>();
      // numbers.Add(5);

      Console.WriteLine("The numbers in the range [0, 5]");
      PrintNumbersInRange(numbers, 0, 5);

      Console.WriteLine("The numbers in the range [3, 10]");
      PrintNumbersInRange(numbers, 3, 10);
    }
    public static void PrintNumbersInRange (numbers, int start, int end)
    {
      List<int> numbers = new List<int>();
      while (true) {
        int input = Convert.ToInt32(Console.ReadLine());
        numbers.Add(input);
      }
      int index = 0;
      while (index < numbers.Count)
      {
        if ((numbers[index]> start) && (numbers[index] < end))
        {
          Console.WriteLine(numbers[index]);
        }
        index++;
      }
    }

    
  }
}

