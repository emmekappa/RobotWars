namespace RobotWars.Tests.Console
{
    using System;
    using NUnit.Framework;
    using RobotWars.Console;
    using SharpTestsEx;

    [TestFixture]
    public class DirectionFactoryTests
    {
        [Test]
        [TestCase("W", typeof (WestDirection))]
        [TestCase("w", typeof (WestDirection))]
        [TestCase("E", typeof (EastDirection))]
        [TestCase("e", typeof (EastDirection))]
        [TestCase("N", typeof (NorthDirection))]
        [TestCase("n", typeof (NorthDirection))]
        [TestCase("S", typeof (SouthDirection))]
        [TestCase("s", typeof (SouthDirection))]
        public void Create_should_create_the_right_Direction(string direction, Type expectedType)
        {
            DirectionFactory.Create(direction).GetType()
                            .Should().Be.EqualTo(expectedType);
        }

        [Test]
        public void Create_should_throw_ArgumentException_when_directions_is_unknown()
        {
            Assert.Throws<ArgumentException>(() => DirectionFactory.Create("k"));
        }
    }
}