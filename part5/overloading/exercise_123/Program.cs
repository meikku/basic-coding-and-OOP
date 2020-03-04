using System;

namespace exercise_123
{
  class Program
  {
    public static void Main(string[] args)
    {
      // You can test your code here.
      Counter counter = new Counter(5);
      Console.WriteLine(counter); // print 5
      counter.Decrease();
      Console.WriteLine(counter); // print 4
      counter.Decrease(8);
      Console.WriteLine(counter); // print -4
      counter.Decrease(-1);
      Console.WriteLine(counter); // print -4
      counter.Increase();
      Console.WriteLine(counter); // print -3
      counter.Increase(100);
      Console.WriteLine(counter); // print 97
      counter.Increase(-100); 
      Console.WriteLine(counter); // print 97

      
      
    }
  }
}
