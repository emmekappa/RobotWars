using NUnit.Framework;
using SharpTestsEx;

namespace RobotWars.Tests
{
    [TestFixture]
    public class EastDirectionTests
    {
        private EastDirection eastDirection;

        [SetUp]
        public void SetUp()
        {
            eastDirection = new EastDirection();
        }

        [Test]
        public void MoveForward_should_increase_X_coordinate_by_one()
        {
            var newPosition = eastDirection.MoveForward(new Coordinate(5, 5));

            newPosition.X
                       .Should().Be.EqualTo(6);
        }

        [Test]
        public void MoveForward_should_not_change_Y_coordinate()
        {
            var newPosition = eastDirection.MoveForward(new Coordinate(5, 5));

            newPosition.Y
                       .Should().Be.EqualTo(5);
        }
    }
}