using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Quest_RPG.player
{
    public class Skill
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int EffectValue { get; set; }

        public Skill(string name, string description, int effectValue)
        {
            Name = name;
            Description = description;
            EffectValue = effectValue;
        }
    }
}
