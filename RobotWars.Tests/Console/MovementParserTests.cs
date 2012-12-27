using System.Linq;
using NUnit.Framework;
using RobotWars.Console;
using SharpTestsEx;

namespace RobotWars.Tests.Console
{
    [TestFixture]
    public class MovementParserTests
    {
        [Test]
        public void Should_parse_Movements()
        {
            MovementParser.Parse("LMLMR")
                          .Select(x => x.GetType())
                          .Should()
                          .Have.SameSequenceAs(typeof (LeftMovement), typeof (ForwardMovement), typeof (LeftMovement),
                                               typeof (ForwardMovement), typeof (RightMovement));
        }

        [Test]
        public void Should_parse_empty_string()
        {
            MovementParser.Parse("")
                          .Select(x => x.GetType())
                          .Should().Have.SameSequenceAs();
        }
    }
}