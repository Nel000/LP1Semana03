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
            
            // Inform user of what's going to be printed
            Console.Write($"'{s}' without '{c}': ");

            // FOREACH loop prints string char by char, without user input char
            foreach(char aC in s)
            {
                if (aC != c)
                    Console.Write(aC);
            }
        }
    }
}
