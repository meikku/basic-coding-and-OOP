using System;
using System.IO;

namespace sandbox
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = File.ReadAllText("text.txt");
            Console.WriteLine("This was done with ReadAllText.");
            Console.WriteLine(text);

            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Enter name and age separated by a comma:");
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                string[] pieces = input.Split(",");
                Console.WriteLine("Name: " + pieces[0] + ", age: " + pieces[1]);
            }


        }
    }
}

