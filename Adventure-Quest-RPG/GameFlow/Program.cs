using Adventure_Quest_RPG.monsters;
using Adventure_Quest_RPG.player;

namespace Adventure_Quest_RPG.GameFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            try
            {
               Adventure adv= new Adventure();
            adv.gameFlow();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


        }
    }
}
