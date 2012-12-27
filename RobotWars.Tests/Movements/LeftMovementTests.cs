using NUnit.Framework;

namespace RobotWars.Tests.Movements
{
    [TestFixture]
    public class LeftMovementTests : MovementTestsBase
    {
        [SetUp]
        public void SetUp()
        {
            leftMovement = new LeftMovement();
        }

        private LeftMovement leftMovement;

        [Test]
        public void ExecuteOn_should_dispatch_a_RotateLeft_to_the_Robot()
        {
            leftMovement.ExecuteOn(RobotMock.Object);

            RobotMock.Verify(x => x.RotateLeft());
        }
    }
}