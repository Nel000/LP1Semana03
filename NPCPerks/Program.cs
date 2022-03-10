using System;

namespace NPCPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reference to NPC traits enum
            NPCTraits npcTraits;

            // The number of NPCs
            int npcNum;

            // The array that stores each NPC
            int[][] npc;

            // Ask user for number of NPCs
            Console.Write("Insert the number of NPCs in your game: ");

            // Store user input in NPC number variable
            npcNum = Convert.ToInt32(Console.ReadLine());
            npc = new int[npcNum][];

            // Request traits for each NPC
            Console.WriteLine("For each NPC, insert up to 4 traits:");

            // Details on trait attribution
            Console.WriteLine("Stealth  (1)");
            Console.WriteLine("Combat   (2)");
            Console.WriteLine("Lockpick (3)");
            Console.WriteLine("Luck     (4)");

            // FOR loop to the amount given by the user
            for (int i = 0; i < npcNum; i++)
            {
                Console.Write($"NPC {i}: ");
                for (int j = 0; j <= 4; j++)
                {   
                    
                }
            }

            // Goes through array of NPCs
        }
    }
}
