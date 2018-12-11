namespace AbstractFactoryPattern
{
    public class UFOBossEnemyShipFactory : IEnemyShipFactory
    {
        public IESEngine AddESEngine()
        {
            return new ESUFOBossEngine();
        }

        public IEsWeapon AddESGun()
        {            
            return new ESUFOBossGun();
        }
    }
}