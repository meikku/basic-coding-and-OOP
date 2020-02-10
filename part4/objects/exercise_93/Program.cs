using System;

namespace exercise_93
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT TOUCH THE OTHER FILE!
      // Do your code here!
      Account meikkusAccount = new Account("Meikku´s account", 100.00); 
      meikkusAccount.Deposit(20.0);
      Console.WriteLine(meikkusAccount.balance);
    }
  }
}



