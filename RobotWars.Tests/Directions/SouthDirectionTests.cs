namespace RobotWars.Tests.Directions
{
    using NUnit.Framework;
    using SharpTestsEx;

    [TestFixture]
    public class SouthDirectionTests
    {
        [SetUp]
        public void SetUp()
        {
            southDirection = new SouthDirection();
        }

        private SouthDirection southDirection;

        [Test]
        public void MoveForward_should_decrease_Y_coordinate_by_one()
        {
            Coordinate newPosition = southDirection.MoveForward(new Coordinate(5, 5));

            newPosition.Y
                       .Should().Be.EqualTo(4);
        }

        [Test]
        public void MoveForward_should_not_change_Y_coordinate()
        {
            Coordinate newPosition = southDirection.MoveForward(new Coordinate(5, 5));

            newPosition.X
                       .Should().Be.EqualTo(5);
        }

        [Test]
        public void RotateLeft_should_return_EastDirection()
        {
            southDirection.RotateLeft()
                          .Should().Be.OfType<EastDirection>();
        }

        [Test]
        public void RotateRight_should_return_WestDirection()
        {
            southDirection.RotateRight()
                          .Should().Be.OfType<WestDirection>();
        }
    }
}