using System;

namespace PercorreString
{
    class Program
    {
        static void Main(string[] args)
        {
            // The user input string and char
            string s, sC;
            char c ;

            // Ask user for string
            Console.Write("Please write a string: ");

            // Store user input in string
            s = Console.ReadLine();

            // Ask user for char
            Console.Write("Please write a character: ");

            // Store user input in char
            sC = Console.ReadLine();

            // Convert char in string to char variable
            c = sC[0];
            
            Console.Write($"'{s}' without '{c}': ");

            // FOR loop prints string char by char, whitout user input char
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != c)
                    Console.Write(s[i]);
            }
        }
    }
}
