namespace RobotWars.Tests
{
    using NUnit.Framework;
    using SharpTestsEx;

    [TestFixture]
    public class CoordinateTests
    {
        [SetUp]
        public void SetUp()
        {
            coordinate = new Coordinate(5, 5);
        }

        private Coordinate coordinate;

        [Test]
        public void Clone_should_create_a_new_instance_of_Coordinate()
        {
            coordinate.Clone()
                      .Should().Not.Be.SameInstanceAs(coordinate);
        }

        [Test]
        public void Equals_should_return_false_when_Xs_are_differents()
        {
            new Coordinate(10, 5)
                .Should().Not.Be.EqualTo(new Coordinate(11, 5));
        }

        [Test]
        public void Equals_should_return_false_when_Ys_are_differents()
        {
            new Coordinate(10, 5)
                .Should().Not.Be.EqualTo(new Coordinate(10, 6));
        }

        [Test]
        public void Equals_should_return_true_when_Xs_and_Ys_are_the_same()
        {
            new Coordinate(10, 5)
                .Should().Be.EqualTo(new Coordinate(10, 5));
        }
    }
}