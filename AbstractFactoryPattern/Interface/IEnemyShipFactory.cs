namespace AbstractFactoryPattern
{
    public interface IEnemyShipFactory
    {
        IEsWeapon AddESGun();
        IESEngine AddESEngine();
    }
}
