using System;
using System.Collections.Generic;

namespace exercise_133
{
  class Program
  {
    public static void Main(string[] args)
    {
      Money money = new Money(100, 00);   
      Money moreMoney = new Money(500, 50);

      Money combined = money.Plus(moreMoney);

      Console.WriteLine(money); // 100.00
      Console.WriteLine(moreMoney); // 500.50
      Console.WriteLine(combined); // 600.50

      Money lessMoney = moreMoney.Minus(money);

      Console.WriteLine(money); // 100.00
      Console.WriteLine(moreMoney); // 500.50
      Console.WriteLine(lessMoney); // 400.50

      lessMoney = lessMoney.Minus(money);

      Console.WriteLine(money); // 100.00
      Console.WriteLine(moreMoney); // 500.50
      Console.WriteLine(lessMoney); // 300.50

      Console.WriteLine(lessMoney.LessThan(moreMoney)); 
      Console.WriteLine(lessMoney.LessThan(money));

      lessMoney = lessMoney.Minus(moreMoney);
      Console.WriteLine(lessMoney);
    }
  }
}
