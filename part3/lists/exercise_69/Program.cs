using System;
using System.Collections.Generic;

namespace exercise_69
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();


            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == -1)
                {
                    break;
                }
                list.Add(input);

            }

            Console.WriteLine("From where?");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Where to?");
            int end = Convert.ToInt32(Console.ReadLine());
            int index = 0; // aloitetaan listan alusta
            while (index < list.Count)
            {
                if ((list[index] >= start) && (list[index] <= end)) // jos listan arvo on suurempi kuin alkunumero ja pienempi kuin loppu
                {
                    Console.WriteLine(list[index]); // printtaa listan arvo

                }
                index++; // indeksi kasvaa, siirry seuraavaan kohtaan listassa       
            }
        }
    }
}
