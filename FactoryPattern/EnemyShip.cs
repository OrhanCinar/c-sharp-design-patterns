﻿using System;

namespace FactoryPattern
{
    public abstract class EnemyShip
    {
        string name;
        double amtDamage;

        public string GetName() { return name; }
        public void SetName(string newName) { name = newName; }

        public double GetDamage() { return amtDamage; }
        public void SetDamage(double newName) { amtDamage = newName; }

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
            Console.WriteLine($"{GetName()} attacks and does {GetDamage()}");
        }
    }
}
