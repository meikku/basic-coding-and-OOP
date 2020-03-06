using System.Collections.Generic;
using System;

namespace exercise_135
{
    public class JokeManager // luodaan luokka
    {
        private List<string> jokes; // luodaan instanssimuuttuja: lista
        public JokeManager()
        {
            this.jokes = new List<string>(); // uusi jokes-lista 
        }
        public void AddJoke(string joke) // metodi jossa lisätään vitsejä listalle
        {

            this.jokes.Add(joke);
        }
        public string DrawJoke() // metodi jossa vedetään listalta satunnainen vitsi

        {
            
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
            
            foreach (string joke in jokes)
            {
                Console.WriteLine(joke);
            }
        }
    }

}