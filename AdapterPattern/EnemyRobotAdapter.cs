namespace AdapterPattern
{
    public class EnemyRobotAdapter : EnemyAttacker
    {
        EnemyRobot theRobot;

        public EnemyRobotAdapter(EnemyRobot newRobot)
        {
            theRobot = newRobot;
        }

        public void AssignDriver(string driverName)
        {
            theRobot.ReactToHuman(driverName);
        }

        public void DriveForward()
        {
            theRobot.WalkForward();
        }

        public void FireWeapon()
        {
            theRobot.SmashWithHand();
        }
    }
}
