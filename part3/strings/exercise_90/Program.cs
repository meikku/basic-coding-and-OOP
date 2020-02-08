using System;
using System.Collections.Generic;

namespace exercise_90
{
    class Program
    {
        public static void Main(string[] args)
        {
            int oldest = 0;          
            while (true) // tehdään luuppi
            {
                string input = Console.ReadLine(); // luetaan syöte käyttäjältä
                if (input == "")
                {
                    break; // jos syöte on tyhjä, lopetetaan
                }

                string[] pieces = input.Split(","); // jaetaan syöte pilkun kohdalta
                int age = Convert.ToInt32(pieces[1]); // muunnetaan syötteen jälkiosa luvuksi
                
                if (age > oldest) {
                  oldest = age;
                }
                
            }
            Console.WriteLine("Age of the oldest: " + oldest);
        }
    }
}



