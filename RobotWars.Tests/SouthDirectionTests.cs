using NUnit.Framework;
using SharpTestsEx;

namespace RobotWars.Tests
{
    [TestFixture]
    public class SouthDirectionTests
    {
        private SouthDirection southDirection;

        [SetUp]
        public void SetUp()
        {
            southDirection = new SouthDirection();
        }

        [Test]
        public void MoveForward_should_decrease_Y_coordinate_by_one()
        {
            var newPosition = southDirection.MoveForward(new Coordinate(5, 5));

            newPosition.Y
                       .Should().Be.EqualTo(4);
        }

        [Test]
        public void MoveForward_should_not_change_Y_coordinate()
        {
            var newPosition = southDirection.MoveForward(new Coordinate(5, 5));

            newPosition.X
                       .Should().Be.EqualTo(5);
        }

        [Test]
        public void RotateLeft_should_return_EastDirection()
        {
            southDirection.RotateLeft()
                .Should().Be.OfType<EastDirection>();
        }
    }
}