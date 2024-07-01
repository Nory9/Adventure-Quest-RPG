using Adventure_Quest_RPG;

namespace AdventureQuestTests
{
    public class UnitTest1
    {
        [Fact]
        public void PlayerAttackReducesEnemyHealth()
        {
            Player player = new Player("Muath Mhawich", 30, 800, 10);
            Monster dragon = new Dragon("dragon", 30, 600, 10);

            BattleSystem.Attack(player, dragon);

            Assert.True(dragon.Health < 600);
        }

        [Fact]
        public void EnemyAttackReducesPlayerHealth()
        {
            Player player = new Player("Nour Misk", 20, 800, 10);
            Monster dragon = new Dragon("dragon", 30, 600, 10);

            dragon.Attack(player);

            Assert.True(player.Health < 800);
        }

        [Fact]
        public void WinnerHasPositiveHealthAfterBattle()
        {
            Player player = new Player("Muath Mhawich", 20, 800, 30);
            Monster dragon = new Dragon("dragon", 30, 600, 10);

            BattleSystem.StartBattle(player, dragon);

            Assert.True(player.Health > 0 || dragon.Health > 0);
        }
    }
}