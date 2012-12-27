using NUnit.Framework;
using SharpTestsEx;

namespace RobotWars.Tests
{
    [TestFixture]
    public class EastDirectionTests
    {
        [SetUp]
        public void SetUp()
        {
            eastDirection = new EastDirection();
        }

        private EastDirection eastDirection;

        [Test]
        public void MoveForward_should_increase_X_coordinate_by_one()
        {
            Coordinate newPosition = eastDirection.MoveForward(new Coordinate(5, 5));

            newPosition.X
                       .Should().Be.EqualTo(6);
        }

        [Test]
        public void MoveForward_should_not_change_Y_coordinate()
        {
            Coordinate newPosition = eastDirection.MoveForward(new Coordinate(5, 5));

            newPosition.Y
                       .Should().Be.EqualTo(5);
        }

        [Test]
        public void RotateLeft_should_return_NorthDirection()
        {
            eastDirection.RotateLeft()
                         .Should().Be.OfType<NorthDirection>();
        }

        [Test]
        public void RotateRight_should_return_SouthDirection()
        {
            eastDirection.RotateRight()
                         .Should().Be.OfType<SouthDirection>();
        }
    }
}