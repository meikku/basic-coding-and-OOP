using System;
using System.IO;

namespace sandbox
{
    class Program
    {
        static void Main(string[] args)
        {

             public void Advance(int howManyDays)
        {
            int daysLimit = 30;

            day += howManyDays;
            if (howManyDays > daysLimit)
            {
              int months = howManyDays / daysLimit;
              month = month + months;
              int remainder = howManyDays - (months * daysLimit);
            }
            if (day > daysLimit)
            {
              day = day - daysLimit;
              month++;
            }

            if (month == 13)
            {
              month = 1;
              year++;
            }


        }
    }
}

