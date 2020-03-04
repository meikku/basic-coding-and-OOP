namespace exercise_132
{
    public class SimpleDate
    {
        private int day;
        private int month;
        private int year;

        public SimpleDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public void Advance()
        {
            // Do something here
            this.Advance(1);
        }

        public void Advance(int howManyDays)
        {
            int daysLimit = 30;
            

            day += howManyDays;
            if (day > daysLimit)
            {
              int months = day / daysLimit; 
              month = month + months;
              day = day - (months * daysLimit);
              
             

            
            }
            int monthsLimit = 12;
            if (month > monthsLimit)
            {
              int years = month / monthsLimit;
              month = month - (years * monthsLimit);
              year = year + years;
            }
            // Vois tehdä myös loopin tänne ja siirtää koodin advance-metodiin. 
            // Do something here
        }

        public SimpleDate AfterNumberOfDays(int days)
        {
            SimpleDate newDate = new SimpleDate(day, month, year/* Do something here?*/);

            newDate.Advance(days);

            // Do something here

            return newDate;
        }


        public override string ToString()
        {
            return this.day + "." + this.month + "." + this.year;
        }

        // used to check if this date object (`this`) is before
        // the date object given as the parameter (`compared`)
        public bool Before(SimpleDate compared)
        {
            // first compare years
            if (this.year < compared.year)
            {
                return true;
            }

            // if the years are the same, compare months
            if (this.year == compared.year && this.month < compared.month)
            {
                return true;
            }

            // the years and the months are the same, compare days
            if (this.year == compared.year && this.month == compared.month &&
                this.day < compared.day)
            {
                return true;
            }

            return false;
        }
    }
}