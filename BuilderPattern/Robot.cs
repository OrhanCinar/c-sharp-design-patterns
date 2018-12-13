namespace BuilderPattern
{
    public class Robot : RobotPlan
    {
        string robotHead;
        string robotArms;
        string robotLegs;
        string robotTorso;


        public void SetRobotArms(string arms)
        {
            robotArms = arms;
        }

        public string getRobotArms() { return robotArms; }

        public void SetRobotHead(string head)
        {
            robotHead = head;
        }

        public string getRobotHead() { return robotHead; }

        public void SetRobotLegs(string legs)
        {
            robotLegs = legs;
        }

        public string getRobotLegs() { return robotLegs; }

        public void SetRobotTorso(string torso)
        {
            robotTorso = torso;
        }

        public string getRobotTorso() { return robotTorso; }
    }
}
