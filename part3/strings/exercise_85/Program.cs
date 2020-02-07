using System;
using System.Collections.Generic;

namespace exercise_85 {
  class Program {
    public static void Main (string[] args) {
      Console.WriteLine ("Enter username:");
      string name = Console.ReadLine ();
      Console.WriteLine ("Enter password:");
      string passWord = Console.ReadLine ();

      if ((name == "alex") && (passWord == "sunshine")) {
        Console.WriteLine("You have successfully logged in!");

      } else if (name == "emma" && (passWord == "haskell")) {
        
          Console.WriteLine ("You have successfully logged in!");

        } else {
          Console.WriteLine ("Incorrect username or password!");
        }

      }
    }
  }