namespace FactoryPattern
{
    public class EnemyShipFactory
    {
        public EnemyShip MakeEnemyShip(string newShipType)
        {
            EnemyShip newShip = null;

            if (newShipType.Equals("U"))
            {
                return new UFOEnemyShip();
            }

            if (newShipType.Equals("R"))
            {
                return new RocketEnemyShip();
            }

            if (newShipType.Equals("B"))
            {
                return new BigUFOEnemyShip();
            }

            return newShip;
        }
    }
}
