using System;

namespace AbstractFactoryPattern
{
    public class UFOEnemyShip : EnemyShip
    {
        IEnemyShipFactory shipFactory;

        public UFOEnemyShip(IEnemyShipFactory shipFactory)
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
