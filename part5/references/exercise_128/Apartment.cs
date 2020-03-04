namespace exercise_128
{

    using System;
    public class Apartment
    {

        private int rooms;
        private int squares;
        private int pricePerSquare;

        public int price { get; set; }

        public Apartment(int rooms, int squares, int pricePerSquare)
        {
            this.rooms = rooms;
            this.squares = squares;
            this.pricePerSquare = pricePerSquare;
        }

        public bool LargerThan(Apartment compared)
        {
            while (true)
            {
                if (this.squares > compared.squares)
                {
                    return true;

                }
                return false;
            }


        }

        public int Price()
        {
            price = this.squares * this.pricePerSquare;
            return price;
        }

        public int PriceDifference(Apartment compared)
        {
            // Math.Abs returns the absolute value


            return Math.Abs(compared.Price() - this.Price());
        }

        public bool MoreExpensiveThan(Apartment compared)
        {
            if (this.Price() < compared.Price())
            {
                return false;
            }
            return true;
        }
    }

}
