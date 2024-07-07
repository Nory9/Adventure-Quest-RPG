using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Adventure_Quest_RPG.GameFlow;
using Adventure_Quest_RPG.Inventory_System;

namespace Adventure_Quest_RPG.player
{

    public class Player : IBattleStates
    {

        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Defense { get; set; }
        public Inventory Inventory { get; set; }
        public int Level { get; set; }
        public List<Skill> Skills { get; set; }

        public Player(string name, int health, int attackPower, int defense)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
            Defense = defense;
            Level = 1;
            Inventory = new Inventory();
            Skills = new List<Skill>();
            LearnInitialSkills();
        }

        public void choiseItem(Player player)
        {
            if (player.Inventory.IsEmpty())
            {
                Console.WriteLine("Your inventory is empty.");
            }
            else
            {
                Console.WriteLine("Choose an item to use:");
                player.Inventory.DisplayItems();
                string input = Console.ReadLine();
                bool inputBool = Int32.TryParse(input, out int choice);
                if (inputBool && choice > 0 && choice <= player.Inventory.ItemsCount)
                {
                    Element item = player.Inventory.GetItem(choice - 1);
                    if (item is Weapon weapon)
                    {
                        player.AttackPower += weapon.AttackPower;
                        Console.WriteLine($"You equipped {weapon.Name}. Your attack power increased by {weapon.AttackPower}.");
                    }
                    else if (item is Armor armor)
                    {
                        player.Defense += armor.Defense;
                        Console.WriteLine($"You equipped {armor.Name}. Your defense increased by {armor.Defense}.");
                    }
                    else if (item is Potion potion)
                    {
                        player.Health += potion.HealthRestore;
                        Console.WriteLine($"You used {potion.Name}. Your health increased by {potion.HealthRestore}.");
                    }
                    player.Inventory.RemoveItem(item);
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }

        }
        public void LearnInitialSkills()
        {
            Skills.Add(new Skill("Basic Attack", "A simple attack.", 20));
        }

        public void LevelUp()
        {
            Console.WriteLine($"your level up to :{Level}");
            Level++;
            if (Level == 2) 

            {
                Skills.Add(new Skill("Heal", "Restores 20 health points.", 20));
            }
            else if (Level == 3)
            {
                Skills.Add(new Skill("Power Strike", "A powerful attack dealing extra damage.", 30));
            }
            // Add more skills as needed
        }

        public void UseSkill(Skill skill, dynamic target)
        {
            if (skill.Name == "Heal")
            {
                Health += skill.EffectValue;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"{Name} used {skill.Name} and healed for {skill.EffectValue} health. your health now :{Health}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                target.Health -= skill.EffectValue;
                if (target.Health < 0)
                    target.Health = 0;
                else
                Console.WriteLine($"{Name} used {skill.Name} and dealt {skill.EffectValue} damage to {target.Name}. enemy Helth: {target.Health}");
            }
        }


    }
}
