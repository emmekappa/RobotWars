using System;
using System.Collections.Generic;

namespace RobotWars.Tests.Parser
{
    public class MovementParser
    {
        public static IEnumerable<IMovement> Parse(string input)
        {
            foreach (char c in input)
            {
                yield return CreateMovement(c);
            }
        }

        private static IMovement CreateMovement(char character)
        {
            switch (character)
            {
                case 'L':
                    return new LeftMovement();
                case 'M':
                    return new ForwardMovement();
                case 'R':
                    return new RightMovement();
                default:
                    throw new ArgumentException("Invalid movement. Valid movements are: 'L', 'M' and 'R'");
            }
        }
    }
}