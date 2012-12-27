namespace RobotWars.Console
{
    using System;
    using System.Text.RegularExpressions;

    public static class ArenaParser
    {
        public static Arena Parse(string input)
        {
            var regex = new Regex("(?<maxWidth>\\d+)\\s+(?<maxHeight>\\d+)");
            Match match = regex.Match(input);
            if (!match.Success)
                throw new ArgumentException("The arena dimensions should be '<maxWidth> <maxHeight>' (ex. '10 10')");
            return new Arena(int.Parse(match.Groups["maxWidth"].Value), int.Parse(match.Groups["maxHeight"].Value));
        }
    }
}