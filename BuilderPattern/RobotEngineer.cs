using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class RobotEngineer
    {
        RobotBuilder RobotBuilder;

        public RobotEngineer(RobotBuilder robotBuilder)
        {
            RobotBuilder = robotBuilder;
        }

        public Robot GetRobot()
        {
            return this.RobotBuilder.GetRobot();
        }

        public void MakeRobot()
        {
            this.RobotBuilder.BuildRobotHead();
            this.RobotBuilder.BuildRobotTorso();
            this.RobotBuilder.BuildRobotArms();
            this.RobotBuilder.BuildRobotLegs();
        }
    }
}
