namespace RobotWars.Tests.Directions
{
    using NUnit.Framework;
    using SharpTestsEx;

    [TestFixture]
    public class WestDirectionTests
    {
        [SetUp]
        public void SetUp()
        {
            westDirection = new WestDirection();
        }

        private WestDirection westDirection;

        [Test]
        public void MoveForward_should_decrease_X_coordinate_by_one()
        {
            Coordinate newPosition = westDirection.MoveForward(new Coordinate(5, 5));

            newPosition.X
                       .Should().Be.EqualTo(4);
        }

        [Test]
        public void MoveForward_should_not_change_Y_coordinate()
        {
            Coordinate newPosition = westDirection.MoveForward(new Coordinate(5, 5));

            newPosition.Y
                       .Should().Be.EqualTo(5);
        }

        [Test]
        public void RotateLeft_should_return_SouthDirection()
        {
            westDirection.RotateLeft()
                         .Should().Be.OfType<SouthDirection>();
        }

        [Test]
        public void RotateRight_should_return_NorthDirection()
        {
            westDirection.RotateRight()
                         .Should().Be.OfType<NorthDirection>();
        }
    }
}