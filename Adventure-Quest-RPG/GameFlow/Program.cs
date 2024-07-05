using Adventure_Quest_RPG.monsters;
using Adventure_Quest_RPG.player;

namespace Adventure_Quest_RPG.GameFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Adventure adv= new Adventure();
           // adv.chooseMonster();
            adv.gameFlow();
            //try
            //{
            //    Player player = new Player("Muath Mhawich", 100, 20, 10);
            //    Monster dragon = new Dragon("dragon", 80, 15, 5);

            //    BattleSystem.StartBattle(player, dragon);

            //    if (player.Health > 0)
            //    {
            //        Console.WriteLine("Adventure complete!");
            //    }

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}


        }
    }
}
