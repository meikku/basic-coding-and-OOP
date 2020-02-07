using System;
using System.Collections.Generic;

namespace exercise_88 {
  class Program {
    public static void Main (string[] args) {
      while (true) { // tehdään luuppi
        string input = Console.ReadLine (); // pyydetään käyttäjältä syöte
        if (input == "") { // jos syöte on tyhjä, pysäytetään
          break;
        }
        string[] pieces = input.Split (" "); // jaetaan syöte välilyöntien kohdalta
        Console.WriteLine(pieces[0]); // printataan ensimmäinen sana
        

      }
    }
  }
}