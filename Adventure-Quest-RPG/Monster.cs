using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Quest_RPG
{
    public class Monster : Character

    {
        public Monster(string name, int attackPower, int health, int defence) : base(name, health, attackPower, defence)
        {
        }
        public Monster() : base()
        {
        }

    }
}
