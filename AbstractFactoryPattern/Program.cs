using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            EnemyShipBuilding makeUFOS = new UFOEnemyShipBuilding();

            EnemyShip grunt = makeUFOS.OrderTheShip("UFO");

            Console.WriteLine(grunt + "\n");

            EnemyShip boss = makeUFOS.OrderTheShip("UFO BOSS");

            Console.WriteLine(boss + "\n");

            Console.ReadKey();
        }
    }
}
