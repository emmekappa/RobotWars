using System;

namespace RobotWars
{
    public class OutOfArenaException : Exception
    {
        public OutOfArenaException()
            : base("Position out of the arena")
        {
        }
    }
}