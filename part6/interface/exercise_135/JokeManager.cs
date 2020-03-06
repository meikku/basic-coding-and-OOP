using System.Collections.Generic;
using System;

namespace exercise_135
{
    public class JokeManager // luodaan luokka
    {
        private List<string> jokes; 
        public JokeManager()
        {
            this.jokes = new List<string>(); // lista vitseistä
        }
        public void AddJoke(string joke) // metodi jossa lisätään vitsejä listalle
        {
           
          jokes.Add(joke);
        }
        public string DrawJoke() // metodi jossa vedetään listalta satunnainen vitsi

        {
            Console.WriteLine("Drawing a joke.");

            if (jokes.Count == 0)
            {
                return "Jokes are in short supply.";
            }
            else
            {
                Random draw = new Random();
                int index = draw.Next(0, jokes.Count);
                return jokes[index];
            }
        }
        public void PrintJokes() // metodi jolla tulostetaan kaikki vitsit listalla
        {
            Console.WriteLine("Printing the jokes.");
            foreach (string joke in jokes)
            {
                Console.WriteLine(joke);
            }
        }
    }

}