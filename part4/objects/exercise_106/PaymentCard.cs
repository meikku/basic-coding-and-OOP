using System;
namespace exercise_106
{
  public class PaymentCard
  {
    private double balance;

    public PaymentCard(double openingBalance)
    {
      this.balance = openingBalance; 
      // write code here
    }

    public override string ToString()
    {
      // write code here
      return "The card has a balance of " + this.balance +  " euros";
    }
  }
}
