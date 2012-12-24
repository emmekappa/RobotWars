using System.Collections.Generic;

namespace RobotWars
{
    public class Arena
    {
        private readonly int maxX;
        private readonly int maxY;

        public Arena(int maxX, int maxY)
        {
            robots = new List<Robot>();
            this.maxX = maxX;
            this.maxY = maxY;
        }

        private List<Robot> robots { get; set; }

        public void AddRobot(Robot robot)
        {
            robots.Add(robot);
        }
    }
}