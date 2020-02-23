namespace exercise_126
{
  public class PaymentCard
  {
    public double balance { get; set; }
    

    public PaymentCard(double balance)
    {
      this.balance = balance;
    }

    public void AddMoney(double increase)
    {
      this.balance = this.balance + increase;
    }

    public bool TakeMoney(double amount)
    {
      if (this.balance >= amount)
      {
        this.balance = this.balance - amount;
        return true;
      }
      // implement the method so that it only takes money from the card if
      // the balance is at least the amount parameter.
      // returns true if successful and false otherwise

      return false;
    }
  }
}