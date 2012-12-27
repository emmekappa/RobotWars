using System;

namespace RobotWars.Console
{
    public static class DirectionFactory
    {
        public static DirectionBase Create(string value)
        {            
            switch (value.ToUpper())
            {
                case "N":
                    return new NorthDirection();
                case "E":
                    return new EastDirection();
                case "W":
                    return new WestDirection();
                case "S":
                    return new SouthDirection();
                default:
                    throw new ArgumentException("Unable to parse direction (valid directions are: 'N', 'E', 'W', 'S')");
            }
        }
    }
}