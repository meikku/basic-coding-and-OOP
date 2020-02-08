using System;
using System.Collections.Generic;

namespace exercise_92
{
    class Program
    {
        public static void Main(string[] args)
        {
            int born = 2020; // syntymävuosi -> tästä lähdetään taaksepäin
            int longest = 0; // sanan pituus - > etsitään tästä suurempia
            string name = "kalevi";

            while (true) // tehdään luuppi
            {
                string input = Console.ReadLine(); // luetaan syöte
                if (input == "") // jos syöte tyhjä
                {
                    break; // lopetetaan
                }

                string[] pieces = input.Split(","); // jaetaan syöte pilkun kohdalta
                int birthYear = Convert.ToInt32(pieces[1]); // muunnetaan syötteen jälkipuoli numeroksi
                int length = pieces[0].Length; // lasketaan syötteen ensimmäisen osan pituus
                if (length > longest)
                {
                    longest = length;
                    name = pieces[0];
                }
                if (birthYear < born) // jos syntymävuosi on pienempi kuin tämä vuosi
                {
                    born = birthYear; //merkitään vanhimmaksi
                }
               

            }
            int age = (2020 - born);
            Console.WriteLine("Longest name: " + name);
            Console.WriteLine("Highest age: " + age);

        }
    }
}



