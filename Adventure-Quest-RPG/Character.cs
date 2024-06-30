using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Quest_RPG
{

   public abstract class Character
    {
        public virtual string Name { get; set; }
        public virtual int Health { get; set; }
        public virtual int AttackPower { get; set; }
        public virtual int Defense { get; set; }

        public Character(string name, int health, int attackPower, int defense)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
            Defense = defense;
        }
        public Character()
        {
            Name = "User";
            Health = 30;
            AttackPower = 30;
            Defense = 30;
        }
    }
}
