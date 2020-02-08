using System;
using System.Collections.Generic;

namespace exercise_91
{
    class Program
    {
        public static void Main(string[] args)
        {
            int oldest = 0; // muuttuja iän laskemiseen
            string name = "Oiva";
            while (true) // tehdään luuppi
            {
                string input = Console.ReadLine(); // luetaan syöte
                if (input == "") // jos syöte tyhjä
                {
                    break; // lopetetaan
                }

                string[] pieces = input.Split(","); // jaetaan syöte pilkun kohdalta
                int age = Convert.ToInt32(pieces[1]); // muunnetaan syötteen jälkipuoli numeroksi
                if (age > oldest) // jos ikä vanhin tähän asti
                {
                  oldest = age; //merkitään vanhimmaksi
                  name = pieces[0]; // ja nimi löytyy indeksin kohdalta
                }
            }
          Console.WriteLine("Name of the oldest: " + name);
        }
    }
}



