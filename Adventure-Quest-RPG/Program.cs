namespace Adventure_Quest_RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Player player = new Player("Muath Mhawich", 30, 50, 20);
                Monster dragon = new Dragon("dragon", 40, 60, 20);

                BattleSystem.StartBattle(player, dragon);

                if (player.Health > 0)
                {
                    Console.WriteLine("Adventure complete!");
                }

            }
            catch (Exception ex) { 
             Console.WriteLine(ex.ToString());
            }
           

        }
    }
}
