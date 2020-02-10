using System;

namespace exercise_94
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT TOUCH THE OTHER FILE!
      // Do your code here!
      Account heikkisAccount = new Account("Heikki's account", 1000.0);
      Account personalAccount = new Account("Personal account", 0);
      heikkisAccount.Withdrawal(100.0);
      personalAccount.Deposit(100.0);
      Console.WriteLine(heikkisAccount.ToString());
      Console.WriteLine(personalAccount.ToString());

    } 
  }
}



