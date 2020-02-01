using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Where to?");
      
      int end = Convert.ToInt32(Console.ReadLine());
     

      Console.WriteLine("Where from?");
      
      int start = Convert.ToInt32(Console.ReadLine());

      for (int i = start; i <= end; i++)
      {
        Console.WriteLine(i);
        
      }
    }
  }
}
