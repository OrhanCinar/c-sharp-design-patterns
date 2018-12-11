namespace AbstractFactoryPattern
{
    public abstract class EnemyShipBuilding
    {
        protected abstract EnemyShip MakeEnemyShip(string typeOfShip);

        public EnemyShip OrderTheShip(string typeOfShip)
        {
            EnemyShip theEnemyShip = MakeEnemyShip(typeOfShip);

            theEnemyShip.MakeShip();
            theEnemyShip.DisplayEnemyShip();
            theEnemyShip.FollowHeroShip();
            theEnemyShip.EnemyShipShoots();

            return theEnemyShip;
        }
    }
}
