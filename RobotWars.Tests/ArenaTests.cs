using NUnit.Framework;
using SharpTestsEx;

namespace RobotWars
{
}

namespace RobotWars.Tests
{
    [TestFixture]
    public class ArenaTests
    {
        private readonly Arena arena10x15;

        public ArenaTests()
        {
            arena10x15 = new Arena(10, 15);
        }

        [Test]
        [TestCase(-5, 5)]
        [TestCase(5, -5)]
        [TestCase(11, 5)]
        [TestCase(0, 16)]
        [TestCase(11, 16)]
        [TestCase(-1, -1)]
        public void IsInside_should_return_false_when_Coordinate_is_outside_the_Arena(int x, int y)
        {
            arena10x15.IsInside(new Coordinate(x, y))
                      .Should().Be.False();
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(5, 5)]
        [TestCase(10, 5)]
        [TestCase(0, 15)]
        [TestCase(10, 15)]
        public void IsInside_should_return_true_when_Coordinate_is_inside_the_Arena(int x, int y)
        {
            arena10x15.IsInside(new Coordinate(x, y))
                      .Should().Be.True();
        }

        [Test]
        [TestCase(-1, 5)]
        [TestCase(1, -5)]
        [TestCase(-5, -5)]
        [TestCase(0, 5)]
        [TestCase(5, 0)]
        [TestCase(0, 0)]        
        public void Constructor_should_throw_when_width_or_height_are_not_greater_than_zero(int width, int height)
        {
            Assert.Throws<InvalidArenaSizeException>(() => new Arena(width, height));
        }
    }
}