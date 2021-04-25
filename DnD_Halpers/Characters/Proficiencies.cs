using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterCreation.Items;

namespace CharacterCreation
{
    public class Proficiencies
    {
        List<Tool> Tools { get; set; }
        List<Weapon> Weapons { get; set; }
        List<string> ArmorType { get; set; }
        List<string> Languages { get; set; }

    }
}
