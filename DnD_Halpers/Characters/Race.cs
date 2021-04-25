using System;
using System.Collections.Generic;

namespace CharacterCreation
{
    public class Race
    {
        public string raceName { get; set; }
        public List<string> StatModifiers { get; set; }
        public List<string> Abilities { get; set; }
        public int MovementSpeedModifier { get; set; }
        public SubRace SubRace { get; set; }
        public string Size { get; set; }
        public string Description { get; set; }




    }

    public class SubRace
    {
        public bool hasSubRace { get; set; }
        public string subRaceName { get; set; }
        public List<string> statModifiers { get; set; }
        public List<string> abilities { get; set; }
        public int movementSpeedModifier { get; set; }
        public string size { get; set; }

    }
}
