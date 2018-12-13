namespace BuilderPattern
{
    public interface RobotBuilder
    {
        void BuildRobotHead();

        void BuildRobotTorso();

        void BuildRobotArms();

        void BuildRobotLegs();

        Robot GetRobot();
    }
}
