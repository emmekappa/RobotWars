namespace RobotWars
{
    using System;

    public class OutOfArenaException : Exception
    {
        public OutOfArenaException()
            : base("Position out of the arena")
        {
        }
    }
}