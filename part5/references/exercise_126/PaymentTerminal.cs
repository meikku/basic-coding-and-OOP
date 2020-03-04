namespace exercise_126
{
    public class PaymentTerminal
    {
        public double money { get; private set; }  // amount of cash
        public int coffeeAmount { get; private set; } // number of sold coffees
        public int lunchAmount { get; private set; }  // number of sold lunches

        public double change = 0;
        public double priceCoffee = 2.50;
        public double priceLunch = 10.30;

        public PaymentTerminal()
        {
            this.money = 1000;
            // register initially has 1000 euros of money
        }

        public double DrinkCoffee(double payment)
        {
            if (payment >= priceCoffee)
            {
                this.money = this.money + priceCoffee;
                change = payment - priceCoffee;
                coffeeAmount++;
            }

            // an coffee now costs 2.50 euros
            // increase the amount of cash by the price of an coffee mean and return the change
            // if the payment parameter is not large enough, no coffee is sold and the method should return the whole payment
            else
            {
                change = payment;
            }

            return change;
        }

        public double EatLunch(double payment)
        {
          
          if (payment >= priceLunch)
          {
            this.money = this.money + priceLunch;
            change = payment - priceLunch;
            lunchAmount++;
          }
          else 
          {
            change = payment;
          }
            // a lunch now costs 10.30 euros
            // increase the amount of cash by the price of a lunch and return the change
            // if the payment parameter is not large enough, no lunch is sold and the method should return the whole payment

            return this.change;
        }

        public bool DrinkCoffee(PaymentCard card)
        {
          if (card.balance >= priceCoffee)
          {
            card.balance = card.balance - priceCoffee;
            coffeeAmount++;
            return true;
          }
            // a coffee costs 2.50 euros
            // if the payment card has enough money, the balance of the card is decreased by the price, and the method returns true
            // otherwise false is returned

            return false;
        }

        public bool EatLunch(PaymentCard card)
        {
            if (card.balance >= priceLunch)
            {
              card.balance = card.balance - priceLunch;
              lunchAmount++;
              return true;
            }
            // a lunch costs 10.30 euros
            // if the payment card has enough money, the balance of the card is decreased by the price, and the method returns true
            // otherwise false is returned
            return false;
        }

        public void AddMoneyToCard(PaymentCard card, double sum)
        {
          card.AddMoney(sum);
          this.money = this.money + sum;
            // ...

        }

        public override string ToString()
        {
            return "money: " + money + ", number of sold coffees: " + coffeeAmount + ", number of sold lunches: " + lunchAmount;
        }
    }
}