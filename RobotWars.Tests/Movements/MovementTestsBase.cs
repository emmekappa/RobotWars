using Moq;
using NUnit.Framework;

namespace RobotWars.Tests.Movements
{
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