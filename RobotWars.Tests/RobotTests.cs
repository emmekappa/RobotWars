namespace RobotWars.Tests
{
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class RobotTests
    {
        [SetUp]
        public void SetUp()
        {
            arenaMock = new Mock<Arena>(5, 5);
            arenaMock
                .Setup(x => x.IsInside(It.IsAny<Coordinate>()))
                .Returns(true);

            directionMock = new Mock<DirectionBase>();
            directionMock
                .Setup(x => x.MoveForward(It.IsAny<Coordinate>()))
                .Returns(new Coordinate(0, 0));

            robot = new Robot(new Coordinate(5, 5), directionMock.Object, arenaMock.Object);
        }

        private Robot robot;
        private Mock<DirectionBase> directionMock;
        private Mock<Arena> arenaMock;

        [Test]
        public void MoveForward_should_dispatch_call_to_Direction()
        {
            robot.MoveForward();

            directionMock.Verify(x => x.MoveForward(new Coordinate(5, 5)));
        }

        [Test]
        public void MoveForward_should_throw_when_new_Arena_tells_that_the_Position_is_out_of_bounds()
        {
            var newPosition = new Coordinate(6, 6);
            directionMock
                .Setup(x => x.MoveForward(It.IsAny<Coordinate>()))
                .Returns(newPosition);
            arenaMock
                .Setup(x => x.IsInside(newPosition))
                .Returns(false);

            Assert.Throws<OutOfArenaException>(() => robot.MoveForward());
        }

        [Test]
        public void RotateLeft_should_dispatch_call_to_Direction()
        {
            robot.RotateLeft();

            directionMock.Verify(x => x.RotateLeft());
        }

        [Test]
        public void RotateRight_should_dispatch_call_to_Direction()
        {
            robot.RotateRight();

            directionMock.Verify(x => x.RotateRight());
        }
    }
}