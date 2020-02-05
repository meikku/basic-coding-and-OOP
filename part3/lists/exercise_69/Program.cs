using System;
using System.Collections.Generic;

namespace exercise_69
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>();
      Console.WriteLine("From where?");
      int start = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Where to?");
      int end = Convert.ToInt32(Console.ReadLine());
      int index = 0;
      while (index < list.Count)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == -1)
        {
          break;
        }
        list.Add(input);
        if (input >= start && input <= end)
        {
          Console.WriteLine(list[index]);
          index++;
        }
      }

    }
  }
}
