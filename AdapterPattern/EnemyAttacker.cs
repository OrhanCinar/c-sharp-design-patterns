using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public interface EnemyAttacker
    {
        void FireWeapon();

        void DriveForward();

        void AssignDriver(string driverName);
    }
}
