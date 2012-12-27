namespace RobotWars.Tests.Movements
{
    using NUnit.Framework;

    [TestFixture]
    public class ForwardMovementTests : MovementTestsBase
    {
        [SetUp]
        public void SetUp()
        {
            forwardMovement = new ForwardMovement();
        }

        private ForwardMovement forwardMovement;

        [Test]
        public void ExecuteOn_should_dispatch_a_MoveForward_to_the_Robot()
        {
            forwardMovement.ExecuteOn(RobotMock.Object);

            RobotMock.Verify(x => x.MoveForward());
        }
    }
}