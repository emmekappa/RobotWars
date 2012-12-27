namespace RobotWars.Console
{
    using System;
    using System.Text.RegularExpressions;

    public class RobotLocationParser
    {
        private readonly Arena arena;

        public RobotLocationParser(Arena arena)
        {
            this.arena = arena;
        }

        public Robot Parse(string inputString)
        {
            var regex = new Regex("(?<x>\\d+)\\s+(?<y>\\d+)\\s+(?<direction>\\w)");
            Match match = regex.Match(inputString);
            if (!match.Success)
                throw new ArgumentException("The robot position should be '<X> <Y> <direction>' (ex: '1 2 N')");
            return new Robot(new Coordinate(int.Parse(match.Groups["x"].Value), int.Parse(match.Groups["y"].Value)),
                             DirectionFactory.Create(match.Groups["direction"].Value), arena);
        }
    }
}