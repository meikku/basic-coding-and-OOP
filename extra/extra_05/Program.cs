using System;
using System.Collections.Generic;

namespace extra_05
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      for (int i = 1; i <= 5; i++)
      {
        Console.WriteLine(i);
      }

      List<string> list = new List<string>();
      Console.WriteLine("Give words, 'end' quits:");

      while (true)
      {
        string input = Console.ReadLine();
        if (input == "end")
        {
          break;
        }
        list.Add(input);
      }
      foreach (string line in list)
      {
        Console.WriteLine(line);
      }
    }
  }
}
