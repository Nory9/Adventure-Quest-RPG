using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Quest_RPG.monsters
{
    internal class phoenix : Monster
    {
        public phoenix(string Name="Phoenix", int Health=50, int AttackPower=30, int Defense=20) : base(Name, Health, AttackPower, Defense)
        {
            this.Name = Name;
            this.Health = Health;
            this.AttackPower = AttackPower;
            this.Defense = Defense;
        }
    }

}
