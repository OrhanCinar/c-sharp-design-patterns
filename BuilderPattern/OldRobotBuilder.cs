namespace BuilderPattern
{
    public class OldRobotBuilder : RobotBuilder
    {
        readonly Robot robot;

        public OldRobotBuilder()
        {
            this.robot = new Robot();
        }

        public void BuildRobotArms()
        {
            robot.SetRobotArms("Blowtorch Arms");
        }

        public void BuildRobotHead()
        {
            robot.SetRobotHead("Tin Head");
        }

        public void BuildRobotLegs()
        {
            robot.SetRobotLegs("Roller Skates");
        }

        public void BuildRobotTorso()
        {
            robot.SetRobotTorso("Tin Torso");
        }

        public Robot GetRobot()
        {
            return robot;
        }
    }
}
