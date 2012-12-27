using System;
using NUnit.Framework;
using RobotWars.Console;
using SharpTestsEx;

namespace RobotWars.Tests.Console
{
    [TestFixture]
    public class RobotLocationParserTets
    {
        private RobotLocationParser robotLocationParser;

        [SetUp]
        public void SetUp()
        {
            robotLocationParser = new RobotLocationParser(new Arena(5, 5));
        }

        [Test]
        [TestCase("1 2 N", 1, 2, typeof(NorthDirection))]
        [TestCase("5 5 E", 5, 5, typeof(EastDirection))]
        [TestCase("10 11 W", 10, 11, typeof(WestDirection))]
        [TestCase("9 2 S", 9, 2, typeof(SouthDirection))]
        public void Should_return_RobotPosition(string inputString, int expectedXPosition, int expectedYPosition, Type expectedDirection)
        {
            Robot robot = robotLocationParser.Parse(inputString);

            robot.Coordinate.X.Should().Be.EqualTo(expectedXPosition);
            robot.Coordinate.Y.Should().Be.EqualTo(expectedYPosition);
            robot.Direction.GetType().Should().Be.EqualTo(expectedDirection);
        }
    }
}