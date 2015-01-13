namespace RobotWars.Tests.Movements
{
    using Moq;
    using NUnit.Framework;

    public class MovementTestsBase
    {
        protected Mock<Robot> RobotMock;

        [SetUp]
        public void BaseSetUp()
        {
            RobotMock = new Mock<Robot>(new Coordinate(5, 5), new NorthDirection(), new Arena(10, 10));
        }
    }
}