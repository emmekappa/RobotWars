using System;
using System.Collections.Generic;
using System.Linq;

namespace RobotWars.Console
{
    public static class MovementParser
    {
        public static IEnumerable<IMovement> Parse(string input)
        {
            return input.Select(c => CreateMovement(c));
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