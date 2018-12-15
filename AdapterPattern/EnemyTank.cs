using System;

namespace AdapterPattern
{
    public class EnemyTank : EnemyAttacker
    {
        Random generator = new Random();

        public void AssignDriver(string driverName)
        {
            Console.WriteLine(driverName + " is driving the tank" );
        }

        public void DriveForward()
        {
            int movement = generator.Next(5) + 1;
            Console.WriteLine("Enemy Tank moves " + movement + " spaces");
        }

        public void FireWeapon()
        {
            int attackDamage = generator.Next(10) + 1;

            Console.WriteLine("Enemy Tank Does " + attackDamage + " Damage");
        }
    }
}
