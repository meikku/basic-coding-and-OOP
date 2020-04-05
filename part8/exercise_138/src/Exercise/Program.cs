using System;
using System.Collections.Generic;

namespace Exercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Do something here
            Dictionary<string, string> names = new Dictionary<string, string>();
            names.Add("matthew", "matt");
            names.Add("michael", "mix");
            names.Add("arthur", "artie");

            foreach (KeyValuePair<string, string> kvp in names)
            {
                Console.WriteLine(kvp.Key + "'s nickname is " + kvp.Value);
            }
        }
    }
}
