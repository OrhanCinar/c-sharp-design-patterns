using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            EnemyShip enemyShip = null;

            Console.WriteLine("What type of ship? (U / R / B)");
            var enemyShipOption = Console.ReadLine().ToUpper();
          
            EnemyShipFactory shipFactory = new EnemyShipFactory();
            enemyShip = shipFactory.MakeEnemyShip(enemyShipOption);
            doStuffEnemy(enemyShip);

            Console.ReadKey();
        }

        private static void doStuffEnemy(EnemyShip anEnemyShip)
        {
            anEnemyShip.DisplayEnemyShip();
            anEnemyShip.FollowHeroShip();
            anEnemyShip.EnemyShipShoots();
        }
    }
}
