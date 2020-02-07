using System;
using System.Collections.Generic;

namespace exercise_87 {
  class Program {
    public static void Main (string[] args) {
      while (true) {
        string input = Console.ReadLine ();
        if (input == "") {
          break;
        }
        string[] pieces = input.Split (" ");
        int index = 0;
        while (index < pieces.Length) {
          string word = (pieces[index]);
          index++;
          if (word.Contains("av") )
          {
            Console.WriteLine(word);
          }
        }

      }
    }

  }

}