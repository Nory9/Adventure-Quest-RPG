using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Quest_RPG.monsters
{
    public class BossMonster : Monster
    {
        public BossMonster(string Name="Boss Monster", int Health=500, int AttackPower=500, int Defense=500) : base(Name, Health, AttackPower, Defense)
        {
            this.Name = Name;
            this.Health = Health;
            this.AttackPower = AttackPower;
            this.Defense = Defense;
        }
    }
}
