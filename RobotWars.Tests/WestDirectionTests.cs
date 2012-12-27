using NUnit.Framework;
using SharpTestsEx;

namespace RobotWars.Tests
{
    [TestFixture]
    public class WestDirectionTests
    {
        private WestDirection westDirection;

        [SetUp]
        public void SetUp()
        {
            westDirection = new WestDirection();
        }

        [Test]
        public void MoveForward_should_decrease_X_coordinate_by_one()
        {
            var newPosition = westDirection.MoveForward(new Coordinate(5, 5));

            newPosition.X
                       .Should().Be.EqualTo(4);
        }

        [Test]
        public void MoveForward_should_not_change_Y_coordinate()
        {
            var newPosition = westDirection.MoveForward(new Coordinate(5, 5));

            newPosition.Y
                       .Should().Be.EqualTo(5);
        }
    }
}