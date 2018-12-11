using System;

namespace AbstractFactoryPattern
{
    public class UFOBossEnemyShip : EnemyShip
    {
        IEnemyShipFactory shipFactory;

        public UFOBossEnemyShip(IEnemyShipFactory shipFactory)
        {
            this.shipFactory = shipFactory;
        }

        public override void MakeShip()
        {
            Console.WriteLine($"Making enemy ship {GetName()}");
            weapon = shipFactory.AddESGun();
            engine = shipFactory.AddESEngine();
        }
    }
}