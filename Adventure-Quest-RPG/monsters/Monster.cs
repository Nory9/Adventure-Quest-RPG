using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adventure_Quest_RPG.GameFlow;

namespace Adventure_Quest_RPG.monsters
{

    public abstract class Monster : IBattleStates

    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Defense { get; set; }

        public Monster(string Name, int Health, int AttackPower, int Defense)
        {
            this.Name = Name;
            this.Health = Health;
            this.AttackPower = AttackPower;
            this.Defense = Defense;

        }


        //  public abstract void Attack(Player player);


    }
}
