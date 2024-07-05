using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adventure_Quest_RPG.monsters;
using Adventure_Quest_RPG.player;

namespace Adventure_Quest_RPG.GameFlow
{
    public  class BattleSystem
    {
        public  int Attack(dynamic attacker, dynamic target)
        {
            int damage = attacker.AttackPower - target.Defense;
            if (damage < 0)
            {
                damage = target.Defense;

            }


            target.Health -= damage;
            if (target.Health < 0) target.Health = 0;

            Console.WriteLine($"{attacker.Name} attacks {target.Name} for {damage} damage. {target.Name} now has {target.Health} health.");
            return target.Health;
        }

        public  string StartBattle(Player player, Monster enemy)
        {
            string result = "";
            int HEALTH = enemy.Health;
            while (player.Health > 0 && enemy.Health > 0)
            {
                Console.WriteLine("Player's turn:");
                Attack(player, enemy);

                if (enemy.Health == 0)
                {
                    Console.WriteLine("Victory! The enemy has been defeated.");
                    Console.WriteLine($" {enemy.Name}s health is{enemy.Health}");
                    result = "Victory!";
                    break;
                }
                Console.WriteLine("Enemy's turn:");
                Attack(enemy, player);

                if (player.Health == 0)
                {
                    Console.WriteLine("Defeat! The player has been defeated.");
                    Console.WriteLine($" {player.Name}s health is{player.Health}");
                    result = "Defeat!";
                    break;
                }
            }
            enemy.Health = HEALTH;
            return result;
        }
    }
}
