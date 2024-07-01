using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Quest_RPG
{
    public static class BattleSystem
    {
        public static int Attack(Character attacker, Character target)
        {    
            int damage = attacker.AttackPower - target.Defense;
            if (damage < 0) { damage = 2;
                
            }


            target.Health -= damage;
            if (target.Health < 0) target.Health = 0;

            Console.WriteLine($"{attacker.Name} attacks {target.Name} for {damage} damage. {target.Name} now has {target.Health} health.");
            return target.Health;
        }

        public static String StartBattle(Player player, Monster enemy)
        {
            String result = "";
            while (player.Health > 0 && enemy.Health > 0)
            {
                Console.WriteLine("Player's turn:");
                Attack(player, enemy);

                if (enemy.Health == 0)
                {
                    Console.WriteLine("Victory! The enemy has been defeated.");
                    result = "Victory!";
                    break;
                }

                Console.WriteLine("Enemy's turn:");
                enemy.Attack(player);

                if (player.Health == 0)
                {
                    Console.WriteLine("Defeat! The player has been defeated.");
                    result = "Defeat!";
                    break;
                }
            }
            return result;
        }
    }
}
