using System;

namespace exercise_46
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      string userInput = Console.ReadLine();
      int number = Convert.ToInt32(userInput);
     

      while (number <= 100)
      {
        
        Console.WriteLine(number);
        number = number + 1; 
      }

    }
  }
}
