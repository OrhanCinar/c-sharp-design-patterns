namespace AbstractFactoryPattern
{
    public class UFOEnemyShipFactory : IEnemyShipFactory
    {       
        public IESEngine AddESEngine()
        {
            return new ESUFOEngine();
        }

        public IEsWeapon AddESGun()
        {
            return new ESUFOGun();
        }
    }
}