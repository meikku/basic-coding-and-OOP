﻿using System;

namespace exercise_43
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      string numberGiven = Console.ReadLine();
      int number = Convert.ToInt32(numberGiven);

      if (number < 0)
      {
        Console.WriteLine(number * -1);
      }
      else 
      {
        Console.WriteLine(number);
      }
    }
  }
}
