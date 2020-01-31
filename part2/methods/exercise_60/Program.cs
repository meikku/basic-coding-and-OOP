﻿using System;

namespace exercise_60
{
  class Program
  {
    public static void PrintStars(int number)
    {
      int round = 1; 
      while(round<=number)
      {Console.Write("*");
      round++;
      }
      Console.WriteLine("");
    
    }
    public static void PrintSquare(int size)
    {
      int round = 1;
      while (round <= size)
      {
        PrintStars(size);
        round++;
      }     
    }
    public static void PrintRectangle(int width, int height)
    {
      int round = 1; 
      while (round <= height)
      {PrintStars(width);
      round++;
      }
    }
    public static void PrintTriangle(int size)
    {
      int round = 1;
      while (round <= size)
      {
        PrintStars(round);
        round++;        
      }
    }
    public static void Main(String[] args)
    { 
      PrintStars(6);
      PrintSquare(4);
      PrintRectangle(17,3);
      PrintTriangle(5);

    }
  }
}
