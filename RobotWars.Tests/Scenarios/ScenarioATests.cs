namespace RobotWars.Tests.Scenarios
{
    using NUnit.Framework;
    using SharpTestsEx;

    [TestFixture]
    [Category("Functional")]
    public class ScenarioATests
    {
        [SetUp]
        public void SetUp()
        {
            robotA = new Robot(new Coordinate(1, 2), new NorthDirection(), new Arena(5, 5));
        }

        private Robot robotA;

        [Test]
        public void ScenarioA_should_be_satisfy()
        {
            robotA.RotateLeft();
            robotA.MoveForward();
            robotA.RotateLeft();
            robotA.MoveForward();
            robotA.RotateLeft();
            robotA.MoveForward();
            robotA.RotateLeft();
            robotA.MoveForward();
            robotA.MoveForward();

            robotA.Coordinate.X.Should().Be.EqualTo(1);
            robotA.Coordinate.Y.Should().Be.EqualTo(3);
            robotA.Direction.Should().Be.OfType<NorthDirection>();
        }
    }
}