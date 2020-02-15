using System;
using System.Collections.Generic;

namespace exercise_110
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Item> items = new List<Item>(); // tehdään lista

            while (true)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine(); // luetaan syöte
                if (name == "") // tyhjällä lopetetaan
                {
                    break;
                }


                items.Add(new Item(name)); // muuten lisätään syöte listalle


            }
            Console.WriteLine();
            int i = 0;
            while (i < items.Count)
            {
                Console.WriteLine(items[i]);
                i++;
            }

        }




        // IMPLEMENT YOUR CODE IN HERE!

    }
}




