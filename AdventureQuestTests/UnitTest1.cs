using Adventure_Quest_RPG.GameFlow;
using Adventure_Quest_RPG.monsters;
using Adventure_Quest_RPG.player;
using static Adventure_Quest_RPG.GameFlow.Adventure;

namespace AdventureQuestTests
{
    public class UnitTest1
    { 
        BattleSystem battleSystem = new BattleSystem();
        [Fact]
        public void PlayerAttackReducesEnemyHealth()
        {
            Player player = new Player("Muath Mhawich", 30, 800, 10);
            Monster dragon = new Dragon("dragon", 30, 600, 10);
          
            battleSystem.Attack(player, dragon);

            Assert.True(dragon.Health < 600);
        }

        [Fact]
        public void EnemyAttackReducesPlayerHealth()
        {
            Player player = new Player("Nour Misk", 20, 800, 10);
            Monster dragon = new Dragon("dragon", 30, 600, 10);

            battleSystem.Attack(dragon,player);

            Assert.True(player.Health < 800);
        }

        [Fact]
        public void WinnerHasPositiveHealthAfterBattle()
        {
            Player player = new Player("Muath Mhawich", 20, 800, 30);
            Monster dragon = new Dragon("dragon", 30, 600, 10);

            battleSystem.StartBattle(player, dragon);

            Assert.True(player.Health > 0 || dragon.Health > 0);
        }

        [Fact]
        public void Changing_locations() { 
         Adventure adventure = new Adventure();
            string initialLocation = "cave";
            string expected_output = "castle";
            int index = 4;
            string output=adventure.chooseLocation(index, initialLocation);
            Assert.Equal(expected_output, output);
        }


        [Fact]
        public void TestBossMonster()
        {
            Adventure adventure = new Adventure();
            adventure = new Adventure();
            bool bossMonster = false;
            for (int i = 0; i < 100; i++)
            {
                Monster monster = adventure.chooseMonster();

                if (monster is BossMonster)
                {
                    bossMonster = true;
                    break;
                }
            }
            Assert.True(bossMonster);
        }


    }
}