using System;
using System.Collections.Generic;

namespace exercise_76
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(3);
            numbers.Add(2);
            numbers.Add(6);
            numbers.Add(-1);
            Console.WriteLine(Sum(numbers));

            numbers.Add(5);
            numbers.Add(1);
            Console.WriteLine(Sum(numbers));
        }
        public static int Sum(List<int> thisIsWhereWeCount)
        {
            int index = 0;
            int sum = 0;
            while (index < thisIsWhereWeCount.Count)
            {
                sum = sum + thisIsWhereWeCount[index];
                index++;
            }
            return sum;
        }




    }
}


