namespace RobotWars.Tests.Scenarios
{
    using NUnit.Framework;
    using SharpTestsEx;

    [TestFixture]
    [Category("Functional")]
    public class ScenarioBTests
    {
        [SetUp]
        public void SetUp()
        {
            robotB = new Robot(new Coordinate(3, 3), new EastDirection(), new Arena(5, 5));
        }

        private Robot robotB;

        [Test]
        public void ScenarioB_should_be_satisfy()
        {
            robotB.MoveForward();
            robotB.MoveForward();
            robotB.RotateRight();
            robotB.MoveForward();
            robotB.MoveForward();
            robotB.RotateRight();
            robotB.MoveForward();
            robotB.RotateRight();
            robotB.RotateRight();
            robotB.MoveForward();

            robotB.Coordinate.X.Should().Be.EqualTo(5);
            robotB.Coordinate.Y.Should().Be.EqualTo(1);
            robotB.Direction.Should().Be.OfType<EastDirection>();
        }
    }
}