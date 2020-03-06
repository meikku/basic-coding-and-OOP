using System;

namespace exercise_135
{
    public class UserInterface
    {
        private JokeManager joker;
        public UserInterface(JokeManager joker)
        {
            this.joker = joker;
        }
        public void Start()
        {
            ManageJokeRequests();

        }

        public void ManageJokeRequests()
        {
            Console.WriteLine("What a joke!");

            while (true)
            {
                Console.WriteLine("Commands:");
                Console.WriteLine(" 1 - add a joke");
                Console.WriteLine(" 2 - draw a joke");
                Console.WriteLine(" 3 - list jokes");
                Console.WriteLine(" X - stop");

                string command = Console.ReadLine();


                if (command == "X")
                {
                    break;
                }

                if (command == "1")
                {
                    Console.WriteLine("Write the joke to be added:");
                    string joke = Console.ReadLine();
                    joker.AddJoke(joke);
                }
                else if (command == "2")
                {
                    
                    Console.WriteLine("Drawing a joke.");
                    joker.DrawJoke();

                }
                else if (command == "3")
                {
                    Console.WriteLine("Printing the jokes.");
                    joker.PrintJokes();
                }
            }
        }

    }
}