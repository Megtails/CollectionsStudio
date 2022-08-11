using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        Dictionary<string, double> letters = new Dictionary<string, double>();
        string lorem = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
        string[] loremChars = lorem.Split("");

        foreach (string i in loremChars)
        {
            if (!letters.ContainsKey(i))
            {
                letters.Add(i, 1);
            }
            else if (letters.ContainsKey(i))
            {
                letters[i] += 1;
            }

            Console.WriteLine({letters.Keys})
        }

    }
}
