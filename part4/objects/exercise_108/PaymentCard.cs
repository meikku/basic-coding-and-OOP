using System;
namespace exercise_108
{
    public class PaymentCard
    {
        private double balance;

        public PaymentCard(double openingBalance)
        {
            this.balance = openingBalance;
        }
        public void EatLunch()
        {
            while (this.balance >= 10.60)
            {
                this.balance = this.balance - 10.60;
            }
        }
        public void DrinkCoffee()
        {
            while (this.balance >= 2.0)
            {
                this.balance = this.balance - 2.0;
            }
        }
        public override string ToString()
        {
            // write code here
            return "The card has a balance of " + this.balance + " euros";
        }
    }
}