using System;

namespace AbstractFactoryPattern
{
    public abstract class EnemyShip
    {
        string name;

        internal IEsWeapon weapon;
        internal IESEngine engine;


        public string GetName() { return name; }
        public void SetName(string newName) { name = newName; }
        
        public abstract void MakeShip();


        public void FollowHeroShip()
        {
            Console.WriteLine($"{GetName()} is following the hero");
        }

        public void DisplayEnemyShip()
        {
            Console.WriteLine($"{GetName()} is on the screen");
        }

        public void EnemyShipShoots()
        {
            Console.WriteLine($"{GetName()} attacks and does {weapon}");
        }

        public override string ToString()
        {
            string infoOnShip = $"The {name} has a top speed of {engine} and an attach power of {weapon}";
            return infoOnShip;
        }
    }
}
