using System;
using System.Collections.Generic;

namespace exercise_135
{
  class Program
  {
    public static void Main(string[] args)
    {
      // List<string> jokes = new List<string>();
      JokeManager joker = new JokeManager(); 
      UserInterface ui = new UserInterface(joker);
      ui.Start();

    }
  }
} 