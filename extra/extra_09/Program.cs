using System;
using System.Collections.Generic;

namespace extra_09
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Add your code here:
            List<string> list = new List<string>() { "This is a string", "This is magic", "THIS IS PATRICK!" };
            int i = 0;
            while (i < list.Count)
            {
                Console.WriteLine(list[i]);
                i++;
            }
            for (i = 0; i < list.Count; i++)
            {
              Console.WriteLine(list[i]);
            }
            foreach(string line in list)
            {
              Console.WriteLine(line);
            }
        }

    }
}
