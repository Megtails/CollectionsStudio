using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        Dictionary<char, double> letters = new Dictionary<char, double>();
        string lorem = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
        string lowerLorem = lorem.ToLower();
        char[] loremChars = lowerLorem.ToCharArray();

        foreach (char i in loremChars)
        {
            if (i == ' ' || i == ',' || i== '.')
            {
                continue;
            }
            else if (!letters.ContainsKey(i))
            {
                letters.Add(i, 1);
            }
            else if (letters.ContainsKey(i))
            {
                letters[i] += 1;
            }
        }
        foreach (char letter in letters.Keys)
        {
            Console.WriteLine(letter + ": " + letters[letter]);
        }
    }
}
