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

        public object chooseMonster() { 
        List<Monster> list = new List<Monster>();
            list.Add(bossMonster);
            list.Add(dragon);
            list.Add(werewolf);
            list.Add(Phoenix);
            Random random = new Random();
            int res=random.Next(0,4);
           // Console.WriteLine(list[res].Name);
           // list[res].Name;
            return list[res];
        }

        public string chooseLocation(int index) {
            string[] locations = { "forest", "cave", "town"};
            
            return locations[index-1];
        }
        public int validInput(bool test_choice, int choice){
            int choice_v = choice;
            if (test_choice && (choice_v >= 0 && choice_v < 4))
            {
                return choice_v;
                //string location = chooseLocation(choice_v);
                //Console.WriteLine($" you are now in {location}");
            }
            else
            {
                while (test_choice == false || (choice_v < 0 || choice_v > 4))
                {
                    Console.WriteLine("you've entered a ivalid number please try again !!!");
                   string userChoice = Console.ReadLine();
                    test_choice = Int32.TryParse(userChoice, out int choice1);
                    choice_v = choice1;
                }
                return choice_v;
                //string location = chooseLocation(choice_v);
                //Console.WriteLine($" you are now in {location}");
            }

        }

        public string locationDiscevery() {
            Console.WriteLine("choose a location\n: [1] forest \n [2] cave \n [3] town");
            string input=Console.ReadLine();
            bool inputBool= Int32.TryParse(input, out int choice1);
            int valid=validInput(inputBool, choice1);
            string location= chooseLocation(valid);
            return location;
        }
        public void gameFlow() {

            Console.WriteLine("Wellcome to our game");
            Console.WriteLine("please choose an action:\n [1] Discover a new location \n[2] Attack a monster\n [3] exit the game");
            string userChoice = Console.ReadLine();
            bool test_choice=Int32.TryParse(userChoice,out int choice);
           int input= validInput(test_choice,choice);
            BattleSystem battle = new BattleSystem();
            Player player= new Player("Reem",400,500,100);
            switch (input) {
                case 1: {
                       string location= locationDiscevery();
                        Console.WriteLine($"you are now in {location}");
                        // call attack method
                    }
                    break;
                    case 2: {

                        // monster
                        while (player.Health > 0)
                        {
                            dynamic monster = chooseMonster();
                            Console.WriteLine($"you are facing {monster.Name}");
                            battle.StartBattle(player,monster);
                        }
                        Console.WriteLine("Game over your health is 0");
                        Console.WriteLine("");
                    }
                    break;
            }
            }

        }
     

    }

