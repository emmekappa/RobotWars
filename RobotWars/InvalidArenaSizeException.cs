using System;

namespace RobotWars
{
    public class InvalidArenaSizeException : Exception
    {
        public InvalidArenaSizeException()
            : base("Invalid arena size: width and height must be greater than zero")
        {
        }
    }
}