using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public interface RobotPlan        
    {
        void SetRobotHead(string head);

        void SetRobotTorso(string torso);

        void SetRobotArms(string arms);

        void SetRobotLegs(string legs);
    }
}
