using System;

namespace StrategyPattern
{
    public class Animal
    {
        private string name;
        private double height;
        private int weight;
        private string favFood;
        private double speed;
        private string sound;

        public IFlys flyingType;


        public void setName(string newName) { name = newName; }
        public string getName() { return name; }

        public void setHeight(double newHeight) { height = newHeight; }
        public double getheight() { return height; }

        public void setWeight(int newWeight)
        {
            if (newWeight > 0)
            {
                weight = newWeight;
            }
            else
            {
                Console.WriteLine("Weight must be bigger than 0");
            }
        }

        public double getWeight() { return weight; }

        public void setFavFood(string newFavFood) { favFood = newFavFood; }
        public string getFavFood() { return favFood; }

        public void setSpeed(double newSpeed) { speed = newSpeed; }
        public double getSpeed() { return speed; }

        public void setSound(string newSound) { sound = newSound; }
        public string getSound() { return sound; }

        public string tryToFly()
        {
            return flyingType.Fly();
        }

        public void setFlyingAbility(IFlys newFlyType)
        {
            flyingType = newFlyType;
        }
    }
}
