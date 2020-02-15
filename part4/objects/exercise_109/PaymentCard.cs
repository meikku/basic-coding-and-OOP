using System;
namespace exercise_109
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
            if (this.balance >= 10.60)
            {
                this.balance = this.balance - 10.60;
            }
        }
        public void DrinkCoffee()
        {
            if (this.balance >= 2.0)
            {
                this.balance = this.balance - 2.0;
            }
        }   
        public void AddMoney(double amount) {
           
            if (amount <0)
            {
                amount = 0;
            }
            this.balance = this.balance + amount;
            if (this.balance > 150)
            {
                this.balance = 150;
            }
            
   
        }
        public override string ToString()
        {
            // write code here
            return "The card has a balance of " + this.balance + " euros";
        }
    }
}