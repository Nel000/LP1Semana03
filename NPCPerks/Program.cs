using System;

namespace NPCPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reference to NPC traits enum
            NPCTraits[] npcTraits;
            NPCTraits currentTrait;

            // The number of NPCs
            int npcNum;

            // Array containing all trait names
            string[] traitNames = new string[] 
            {
            "Stealth", 
            "Combat", 
            "Lockpick",
            "Luck"
            };

            // Current user input
            string input;

            // Defines when to stop attributing perks to an NPC
            bool hasEnded;

            // Ask user for number of NPCs
            Console.Write("Insert the number of NPCs in your game: ");

            // Store user input in NPC number variable
            npcNum = Convert.ToInt32(Console.ReadLine());

            // Assign number of NPCs to traits variable
            npcTraits = new NPCTraits[npcNum];

            // FOR loop to the amount given by the user
            for (int i = 0; i < npcNum; i++)
            {
                for (int j = 0; j < traitNames.Length; j++)
                {
                    // Begin assigning process
                    hasEnded = false;
                    
                    // Go through possible options
                    do
                    {   
                        // Ask if NPC has a trait
                        Console.WriteLine(
                            $"Does NPC {i + 1} have {traitNames[j]}? (y/n)");
                        // Store user input
                        input = Console.ReadLine();

                        switch (input)
                        {
                            case "y": case "Y":
                                // Convert name in string[] to equivalent in enum
                                Enum.TryParse(traitNames[j], out currentTrait);

                                // Assign current trait to current NPC
                                npcTraits[i] |= currentTrait;

                                // End loop
                                hasEnded = true;
                                break;
                            case "n": case "N":
                                // End loop
                                hasEnded = true;
                                break;
                            default:
                                // Inform user that they gave an invalid answer
                                Console.WriteLine(
                                    "Invalid option");
                                break;
                        }
                    }
                    // Move onto next trait once user gave a valid answer 
                    while (!hasEnded);
                }
            }

            // Extra line before results
            Console.WriteLine();

            // Go through array of NPCs
            for (int i = 0; i < npcNum; i++)
            {
                // Check if current NPC has no traits
                if ((npcTraits[i] & NPCTraits.Combat) != NPCTraits.Combat
                    && (npcTraits[i] & NPCTraits.Combat) != NPCTraits.Combat
                    && (npcTraits[i] & NPCTraits.Lockpick) != NPCTraits.Lockpick
                    && (npcTraits[i] & NPCTraits.Luck) != NPCTraits.Luck)
                {
                    // Details for current NPC
                    Console.WriteLine($"NPC {i + 1} has no perks");
                }
                else
                {
                    // Details for current NPC
                    Console.WriteLine($"NPC {i + 1} has : {npcTraits[i]}");
                }

                // Check if current NPC has Combat and Luck perks
                if ((npcTraits[i] & NPCTraits.Combat) == NPCTraits.Combat
                    && (npcTraits[i] & NPCTraits.Luck) == NPCTraits.Luck)
                {
                    // Print special message
                    Console.WriteLine("\tYou shall win all fights!");
                }
            }
        }
    }
}
