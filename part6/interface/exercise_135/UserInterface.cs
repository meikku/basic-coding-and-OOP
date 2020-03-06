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
                    AddingJokes();
                }
                else if (command == "2")
                {
                    DrawingJokes();

                }
                else if (command == "3")
                {
                    PrintingJokes();
                }
            }

        }
        public void AddingJokes()
        {
            Console.WriteLine("Write the joke to be added:");
            string joke = Console.ReadLine();
            joker.AddJoke(joke);
        }
        public void DrawingJokes()
        {
            Console.WriteLine("Drawing a joke.");
            Console.WriteLine(joker.DrawJoke());

        }
        public void PrintingJokes()
        {
            Console.WriteLine("Printing the jokes.");
            joker.PrintJokes();
        }
    }
}