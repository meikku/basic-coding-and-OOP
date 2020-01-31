using System;

namespace exercise_61
{
  class Program
  {
    public static void Main(String[] args)
    {
      
    
      PrintRightTriangle(10);
      ChristmasTree(12);
      
    
    }

    public static void PrintStars(int number)
    {
      int round = 1; 
      while(round<=number)
      { Console.Write("*");
        round++;
      }
      Console.WriteLine("");
    }

    public static void PrintSpaces(int number)
    {
      int round = 1; 
      while (round<=number)
      { Console.Write(" ");
        round++;
      }
    }

    public static void PrintRightTriangle(int size)
    {
      int round = 1;
      int stars = 1; 
      while (round <= size)
      {
        PrintSpaces(size - round);
        PrintStars(stars);
        stars++;
        round++;
      }
      
    }

    public static void ChristmasTree(int height)
    {
      int round = 1;
      int width = 1;
      int spaces = (height - 1);

      while (round <= height)
      {
        PrintSpaces(spaces);
        PrintStars(width);
        width = width + 2;
        round++;
        spaces--;
      }
        PrintSpaces(height - 2);
        PrintStars(3);
        PrintSpaces(height -2); 
        PrintStars(3);
    }
  }
}
