using System;
using System.Collections.Generic;

namespace exercise_79
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT CHANGE THE FOLLOWING CODE!
      int[] array = new int[10];
      array[0] = 6;
      array[1] = 2;
      array[2] = 8;
      array[3] = 1;
      array[4] = 3;
      array[5] = 0;
      array[6] = 9;
      array[7] = 7;

      Console.WriteLine("Search for?");
      int searching = Convert.ToInt32(Console.ReadLine()); // mitä etsitään, kysytään käyttäjältä
      int index = 0; // ekasta indeksistä aloitetaan
      bool found = false;
      while (index < array.Length) // käydäänpä taas lista läpi
      {
        if (array[index] == searching) // tsekataan löytyykö haluttu numero listalta
        {
          Console.WriteLine(searching + " is at index " + index + "."); // kerrotaan jos löytyy, ja mistä
          found = true;
        }
       
        index++; // indeksi kasvaa
      }
        if (found == false)
        {
          Console.WriteLine(searching + " was not found.");
        }

      // Implement the search functionality here

    }

  }
}


