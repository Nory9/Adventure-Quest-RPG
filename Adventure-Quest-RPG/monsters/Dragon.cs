using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Quest_RPG.monsters
{
    public class Dragon : Monster
    {
        
        public Dragon(string Name="Dragon", int Health=80, int AttackPower=15, int Defense=5) : base(Name, Health, AttackPower, Defense)
        {
            this.Name = Name;
            this.Health = Health;
            this.AttackPower = AttackPower;
            this.Defense = Defense;

        }
        
        //public override void Attack(Player player)
        //{
        //    BattleSystem.Attack(this, player);
        //}
    }
}
