using Adventure_Quest_RPG.monsters;
using Adventure_Quest_RPG.player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Quest_RPG.GameFlow
{
    public class Adventure
    {
        BossMonster bossMonster = new BossMonster();
        phoenix Phoenix = new phoenix();
        Werewolf werewolf = new Werewolf();
        Monster dragon = new Dragon();
        BattleSystem battle = new BattleSystem();
        Vampire vampire = new Vampire();
        Goblin goblin = new Goblin();
        public object chooseMonster() { 
        List<Monster> list = new List<Monster>();
            list.Add(bossMonster);
            list.Add(dragon);
            list.Add(werewolf);
            list.Add(goblin);
            list.Add(Phoenix);
            list.Add(dragon);
            list.Add(vampire);
            list.Add(goblin);
            Random random = new Random();
            int res=random.Next(0,4);
            return list[res];
        }

        public string chooseLocation(int index) {
            string[] locations = { "forest", "cave", "town", "castle", "village" };
            
            return locations[index-1];
        }
        public int validInput(bool test_choice, int choice){
            int choice_v = choice;
            if (test_choice && (choice_v >= 0 && choice_v < 6))
            {
                return choice_v;
            }
            else
            {
                while (test_choice == false || (choice_v < 0 || choice_v > 6))
                {
                    Console.WriteLine("you've entered a ivalid number please try again !!!");
                   string userChoice = Console.ReadLine();
                    test_choice = Int32.TryParse(userChoice, out int choice1);
                    choice_v = choice1;
                }
                return choice_v;
            }

        }

        public string locationDiscevery() {
            Console.WriteLine("choose a location:\n [1] forest \n [2] cave \n [3] town\n [4] castle\n [5] village");
            string input=Console.ReadLine();
            bool inputBool= Int32.TryParse(input, out int choice1);
            int valid=validInput(inputBool, choice1);
            string location= chooseLocation(valid);
            return location;
        }
        public void round(Player player) {

                dynamic monster = chooseMonster();
                Console.WriteLine($"\n\nyou are facing {monster.Name}\n");
               string res= battle.StartBattle(player, monster);

        }
        public int action() {
            Console.WriteLine("\nplease choose an action:\n [1] Discover a new location \n [2] Attack a monster\n [3] Exit the game");
            string userChoice = Console.ReadLine();
            bool test_choice = Int32.TryParse(userChoice, out int choice);
            int input = validInput(test_choice, choice);
            return input;
        }
        public void switchloop(int input,Player player) {
            switch (input)
            {
                case 1:
                    {
                        string location = locationDiscevery();
                        Console.WriteLine($"\nyou are now in {location}");
                        round(player);
                    }
                    break;
                case 2:
                    {
                        round(player);
                    }
                    break;
                case 3:
                    {
                    Environment.Exit(0);
                    }
                    break;
            }

        }
        public bool nameValidation(string name) {
            bool pares=Int32.TryParse(name, out int choice);    
            if(pares==true||name=="")
            return false;
            else return true;
        }
        public void gameFlow() {
             Console.WriteLine("wellcome to our game!\n Enter your name:");
             string name=Console.ReadLine();
            bool validName=nameValidation(name);
            while (!validName) {
                Console.WriteLine("the name you entered is invalid try again");
                 name = Console.ReadLine();
                 validName = nameValidation(name);
            }
             Player player= new Player(name,120,55,76);
            while (player.Health > 0)
            {
                int input = action();
                switchloop(input, player);
            }
            Console.WriteLine("\nGame Over!\nGood luck next time");
        }

        }
     

    }

