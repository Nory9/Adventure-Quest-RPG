using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Quest_RPG.monsters
{
    internal class Goblin : Monster
    {
        public Goblin(string Name = "Goblin", int Health = 70, int AttackPower = 45, int Defense = 30) : base(Name, Health, AttackPower, Defense)
        {
            this.Name = Name;
            this.Health = Health;
            this.AttackPower = AttackPower;
            this.Defense = Defense;
        }
    }

}
