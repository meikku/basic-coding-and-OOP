﻿using System;

namespace exercise_114
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                i++;
            }
            Console.WriteLine(i);
        }
    }
}
