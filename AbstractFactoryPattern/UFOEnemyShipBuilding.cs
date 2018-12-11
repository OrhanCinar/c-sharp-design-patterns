namespace AbstractFactoryPattern
{
    public class UFOEnemyShipBuilding : EnemyShipBuilding
    {
        protected override EnemyShip MakeEnemyShip(string typeOfShip)
        {
            EnemyShip theEnemyShip = null;

            if (typeOfShip.Equals("UFO"))
            {
                IEnemyShipFactory shipPartsFactory = new UFOEnemyShipFactory();
                theEnemyShip = new UFOEnemyShip(shipPartsFactory);
                theEnemyShip.SetName("UFO Grunt Ship");
            }
            else if (typeOfShip.Equals("UFO BOSS"))
            {
                IEnemyShipFactory shipPartsFactory = new UFOBossEnemyShipFactory();
                theEnemyShip = new UFOBossEnemyShip(shipPartsFactory);
                theEnemyShip.SetName("UFO Boss Ship");
            }

            return theEnemyShip;
        }
    }
}
