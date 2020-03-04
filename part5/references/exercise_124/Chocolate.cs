namespace exercise_124
{
    public class Chocolate
    {
        private string brand;
        public int amount { get; set; }

        public int pieces { get; set; }

        public Chocolate(string brand, int amount)
        {
            this.brand = brand;
            this.amount = amount;

        }

        public void EatChocolate(int pieces)
        {

            if (amount <= 0)
            {
                amount = 0;
            }
            else
            {
                amount = amount - pieces;
            }

        }

        public override string ToString()
        {
            return "There is " + amount + " pieces left of " + brand;

        }
    }
}