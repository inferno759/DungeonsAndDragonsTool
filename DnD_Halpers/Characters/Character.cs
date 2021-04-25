using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    public class Character
    {
        public Race RaceType { get; set; }
        public List<Stat> Stats { get; set; }
        public int HitPoints { get; set; }
        public double CarryWeight { get; set; }
        public int characterLevel { get; set; }
        public int movementSpeed { get; set; }
        public List<Skill> Skills { get; set; }
        public int ProficiencyBonus { get; set; }
        public int WalkingSpeed { get; set; }
        public int ArmorClass { get; set; }
        public int Initiative { get; set; }
        



    }
}
