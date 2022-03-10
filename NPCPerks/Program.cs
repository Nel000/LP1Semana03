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

            // The amount of NPC traits
            int traits = 4;

            // The name of the current trait
            string traitName;

            // Defines when to stop attributing perks to an NPC
            bool hasEnded;

            // Auxiliary variable
            int j;

            // Ask user for number of NPCs
            Console.Write("Insert the number of NPCs in your game: ");

            // Store user input in NPC number variable
            npcNum = Convert.ToInt32(Console.ReadLine());

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
                            // Assign 'Stealth' trait to current NPC
                            npcTraits[i] |= NPCTraits.Stealth;
                            break;
                        case "Combat":
                            // Assign 'Combat' trait to current NPC
                            npcTraits[i] |= NPCTraits.Combat;
                            break;
                        case "Lockpick":
                            // Assign 'Lockpick' trait to current NPC
                            npcTraits[i] |= NPCTraits.Lockpick;
                            break;
                        case "Luck":
                            // Assign 'Luck' trait to current NPC
                            npcTraits[i] |= NPCTraits.Luck;
                            break;
                        case "Stop":
                            // Stop requesting traits for current NPC
                            hasEnded = true;
                            break;
                        default:
                            // Retry getting trait for current NPC
                            Console.WriteLine("Not a valid trait");
                            j--;
                            break;
                    }
                    j++;
                }
                // Stop when END condition is met or NPC already has max traits
                while (!hasEnded || j < traits);
            }

            // Go through array of NPCs
            for (int i = 0; i < npcNum; i++)
            {
                // Details for current NPC
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
