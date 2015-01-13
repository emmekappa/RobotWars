namespace RobotWars.Tests.Movements
{
    using NUnit.Framework;

    [TestFixture]
    public class RightMovementTests : MovementTestsBase
    {
        [SetUp]
        public void SetUp()
        {
            rightMovement = new RightMovement();
        }

        private RightMovement rightMovement;

        [Test]
        public void ExecuteOn_should_dispatch_a_RotateRight_to_the_Robot()
        {
            rightMovement.ExecuteOn(RobotMock.Object);

            RobotMock.Verify(x => x.RotateRight());
        }
    }
}