namespace Exercise
{
    using System;
    using System.Collections.Generic;

    public class LotteryRow
    {
        private List<int> numbers;

        public LotteryRow()
        {
            this.RandomizeNumbers();
        }

        public List<int> Numbers()
        {
            this.numbers.Sort();
            return this.numbers;
        }

        public bool ContainsNumber(int number)
        {
            if (this.numbers.Contains(number))
            {
                return true;
            }// Tests whether the number is already among the randomized numbers
            return false;
        }

        public void RandomizeNumbers()
        {
            // initialize the list for numbers
            this.numbers = new List<int>();
            Random random = new Random();

            for (int i = 0; i < 7; i++)
            {
                int lotteryNumber = random.Next(1, 41);
                if (!this.numbers.Contains(lotteryNumber))
                {
                    this.numbers.Add(lotteryNumber);
                }

            }
            // Implement the randomization of the numbers by using the method ContainsNumber() here
        }

    }
}