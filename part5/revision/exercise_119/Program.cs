using System;
using System.IO;


namespace exercise_119
{
  class Program
  {
    public static void Main(string[] args)
    {
      Timer timer = new Timer();
      timer.Advance();
      Console.WriteLine(timer);
    }
  }
}
