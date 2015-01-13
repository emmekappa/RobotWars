namespace RobotWars.Tests.Directions
{
    using NUnit.Framework;
    using SharpTestsEx;

    [TestFixture]
    public class NorthDirectionTests
    {
        [SetUp]
        public void SetUp()
        {
            northDirection = new NorthDirection();
        }

        private NorthDirection northDirection;

        [Test]
        public void MoveForward_should_increase_Y_coordinate_by_one()
        {
            Coordinate newPosition = northDirection.MoveForward(new Coordinate(5, 5));

            newPosition.Y
                       .Should().Be.EqualTo(6);
        }

        [Test]
        public void MoveForward_should_not_change_X_coordinate()
        {
            Coordinate newPosition = northDirection.MoveForward(new Coordinate(5, 5));

            newPosition.X
                       .Should().Be.EqualTo(5);
        }

        [Test]
        public void RotateLeft_should_return_WestDirection()
        {
            northDirection.RotateLeft()
                          .Should().Be.OfType<WestDirection>();
        }

        [Test]
        public void RotateRight_should_return_EastDirection()
        {
            northDirection.RotateRight()
                          .Should().Be.OfType<EastDirection>();
        }
    }
}