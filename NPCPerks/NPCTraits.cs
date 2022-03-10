using System;

namespace NPCPerks
{
    [Flags]
    public enum NPCTraits
    {
        Stealth = 1 << 0,   // 1
        Combat = 1 << 1,    // 2
        Lockpick = 1 << 2,  // 4
        Luck = 1 << 3       // 8
    }
}
