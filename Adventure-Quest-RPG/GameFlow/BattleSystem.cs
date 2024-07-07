using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Adventure_Quest_RPG.Inventory_System;
using Adventure_Quest_RPG.monsters;
using Adventure_Quest_RPG.player;

namespace Adventure_Quest_RPG.GameFlow
{
    public class BattleSystem
    {
         private static Random random = new Random();
        public int Attack(dynamic attacker, dynamic target)
        {
            int damage = attacker.AttackPower - target.Defense;
            if (damage < 0)
            {
                damage = 2;

            }


            target.Health -= damage;
            if (target.Health < 0) target.Health = 0;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{attacker.Name} attacks {target.Name} for {damage} damage. {target.Name} now has {target.Health} health.\n");
            return target.Health;
        }

        public string StartBattle(Player player, Monster enemy)
        {
            string result = "";
            int HEALTH = enemy.Health;
            while (player.Health > 0 && enemy.Health > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Choose an action: [1] Attack [2] Use Skill");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    //enemy.Health -= player.AttackPower;
                    Attack(player, enemy);
                  
                    //Console.WriteLine($"{player.Name} attacked {enemy.Name} for {player.AttackPower} damage . enemy health :{enemy.Health}");
                }
                else if (choice == "2")
                {
                    UseSkill(player, enemy);
                }

                if (enemy.Health <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Victory! The {enemy.Name} has been defeated.\n");
                    HandleItemDrop(player);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"You received a package from {enemy.Name}.");
                    return "Victory!";
                }

                Attack(enemy, player);
                
                //Console.WriteLine($"{enemy.Name} attacked {player.Name} for {enemy.AttackPower} damage. Your health :{player.Health}");
            }
            return "Defeat!";
        }
        public void UseSkill(Player player, dynamic enemy)
        {
            Console.WriteLine("Choose a skill to use:");
            for (int i = 0; i < player.Skills.Count; i++)
            {
             
                Console.WriteLine($"[{i + 1}] {player.Skills[i].Name} - {player.Skills[i].Description}");
            }
            string choice = Console.ReadLine();
            if (int.TryParse(choice, out int skillIndex) && skillIndex > 0 && skillIndex <= player.Skills.Count)
            {
                Skill selectedSkill = player.Skills[skillIndex - 1];
                player.UseSkill(selectedSkill, enemy);
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
        private static Element HandleItemDrop(Player player)
        {
            if (random.NextDouble() < 1) 
            {
                Element droppedItem = GetRandomItem();
                player.Inventory.AddItem(droppedItem);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"You received a {droppedItem.Name}.");
                return droppedItem;
            }
            return null;
        }

        private static Element GetRandomItem()
        {
            int itemType = random.Next(3);
            switch (itemType)
            {
                case 0:
                    return new Weapon { Name = "Sword", Description = "A sharp sword.", AttackPower = 10 };
                case 1:
                    return new Armor { Name = "Shield", Description = "A sturdy shield.", Defense = 10 };
                case 2:
                    return new Potion { Name = "Health Potion", Description = "Restores 20 health.", HealthRestore = 20 };
                default:
                    return null;
            }
        }
    }
}
