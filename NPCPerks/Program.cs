using System;

namespace NPCPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reference to NPC traits enum
            NPCTraits[] npcTraits;

            // The number of NPCs
            int npcNum;

            // The array that stores each NPC
            int[][] npc;

            // The amount of NPC traits
            int traits = 4;

            // The value for each given NPC
            //int npcVal = 0;

            string traitName;

            // Defines when to stop attributing perks to an NPC
            bool hasEnded;

            int j;

            // Ask user for number of NPCs
            Console.Write("Insert the number of NPCs in your game: ");

            // Store user input in NPC number variable
            npcNum = Convert.ToInt32(Console.ReadLine());
            npc = new int[npcNum][];
            // Assign number of NPCs to traits variable
            npcTraits = new NPCTraits[npcNum];

            // Request traits for each NPC
            Console.WriteLine("For each NPC, insert up to 4 traits:");

            // Details on trait attribution
            Console.WriteLine("Stealth");
            Console.WriteLine("Combat");
            Console.WriteLine("Lockpick");
            Console.WriteLine("Luck");

            // FOR loop to the amount given by the user
            for (int i = 0; i < npcNum; i++)
            {
                // Begin assigning process
                hasEnded = false;
                j = 0;
                do 
                {
                    // Ask for trait for current NPC
                    Console.Write($"NPC {i + 1} - Trait {j + 1}: ");

                    // Store user input as current trait
                    traitName = Console.ReadLine();

                    // Go through all possible options
                    switch (traitName)
                    {
                        case "Stealth":
                            npcTraits[i] |= NPCTraits.Stealth;
                            break;
                        case "Combat":
                            npcTraits[i] |= NPCTraits.Combat;
                            break;
                        case "Lockpick":
                            npcTraits[i] |= NPCTraits.Lockpick;
                            break;
                        case "Luck":
                            npcTraits[i] |= NPCTraits.Luck;
                            break;
                        case "Stop":
                            hasEnded = true;
                            break;
                        default:
                            Console.WriteLine("Not a valid trait");
                            j--;
                            break;
                    }
                    j++;
                } 
                while (!hasEnded || j < traits);
            }

            // Goes through array of NPCs
            for (int i = 0; i < npcNum; i++)
            {
                Console.WriteLine($"NPC {i + 1} has : {npcTraits[i]}");

                // Check if current NPC has Combat and Luck perks
                if ((npcTraits[i] & NPCTraits.Combat) == NPCTraits.Combat
                    && (npcTraits[i] & NPCTraits.Luck) == NPCTraits.Luck)
                {
                    // Print special message
                    Console.WriteLine("You shall win all fights!");
                }
            }
        }
    }
}
