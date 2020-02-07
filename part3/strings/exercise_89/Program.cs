using System;
using System.Collections.Generic;

namespace exercise_89 {
  class Program {
    public static void Main (string[] args) {
      while (true) { // tehdään luuppi
        string input = Console.ReadLine (); // pyydetään käyttäjältä syöte
        if (input == "") { // jos syöte on tyhjä, pysäytetään
          break;
        }
        string[] pieces = input.Split (" "); // jaetaan syöte välilyöntien kohdalta

        for (int i = 0; i < pieces.Length; i++) {
          if (i == (pieces.Length - 1)) {
            Console.WriteLine (pieces[i]);
          }

        }

      }

    }
  }
}