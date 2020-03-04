using System;

namespace exercise_124
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Implement your program here!
      Chocolate gnb = new Chocolate("Green & Black's", 5);
      Console.WriteLine(gnb);
      gnb.EatChocolate(2);
      Console.WriteLine(gnb);

      
      Chocolate fudge = new Chocolate("Mrs Tilly's", 2);
      Console.WriteLine(fudge);
      fudge = null;
      fudge.EatChocolate(1);
      Console.WriteLine(fudge);

      

      
    }
  }
}
