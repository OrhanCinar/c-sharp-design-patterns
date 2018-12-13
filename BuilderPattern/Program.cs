using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RobotBuilder oldStyleRobot = new OldRobotBuilder();

            RobotEngineer robotEngineer = new RobotEngineer(oldStyleRobot);

            robotEngineer.MakeRobot();

            Robot firstRobot = robotEngineer.GetRobot();

            Console.WriteLine("Robot Build");

            Console.WriteLine($"Robot Head Type {firstRobot.getRobotHead()}");
            Console.WriteLine($"Robot Torso Type {firstRobot.getRobotTorso()}");
            Console.WriteLine($"Robot Arms Type {firstRobot.getRobotArms()}");
            Console.WriteLine($"Robot Legs Type {firstRobot.getRobotLegs()}");

            Console.ReadKey();
        }
    }
}
