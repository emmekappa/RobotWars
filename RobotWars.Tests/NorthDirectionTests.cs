using NUnit.Framework;
using SharpTestsEx;

namespace RobotWars.Tests
{
    [TestFixture]
    public class NorthDirectionTests
    {
        private NorthDirection northDirection;

        [SetUp]
        public void SetUp()
        {
            northDirection = new NorthDirection();
        }

        [Test]
        public void MoveForward_should_increase_Y_coordinate_by_one()
        {
            var newPosition = northDirection.MoveForward(new Coordinate(5, 5));

            newPosition.Y
                .Should().Be.EqualTo(6);
        }

        [Test]
        public void MoveForward_should_not_change_X_coordinate()
        {
            var newPosition = northDirection.MoveForward(new Coordinate(5, 5));

            newPosition.X
                .Should().Be.EqualTo(5);
        }
    }
}