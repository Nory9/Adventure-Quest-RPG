using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Quest_RPG
{
    public class Dragon:Monster
    {
        public Dragon(string name, int health , int attackPower , int defense )
     : base(name, health, attackPower, defense) { }

        public override void Attack(Player player)
        {
            BattleSystem.Attack(this, player);
        }
    }
}
