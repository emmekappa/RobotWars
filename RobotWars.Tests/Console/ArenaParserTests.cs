using System;
using NUnit.Framework;
using RobotWars.Console;
using SharpTestsEx;

namespace RobotWars.Tests.Console
{
    [TestFixture]
    public class ArenaParserTests
    {
        [Test]
        [TestCase("5 5", 5, 5)]
        [TestCase("10    5", 10, 5)]        
        [TestCase("1 1", 1, 1)]        
        public void Parse_should_return_the_Arena(string inputString, int expectedArenaWidth, int expecredArenaHeight)
        {
            var arena = ArenaParser.Parse(inputString);
            
            arena.Width.Should().Be.EqualTo(expectedArenaWidth);
            arena.Height.Should().Be.EqualTo(expecredArenaHeight);
        }

        [Test]
        [TestCase("1")]
        [TestCase("1 a")]
        [TestCase(" a ")]
        public void Parse_should_throw_an_ArgumentException_when_unable_to_parse_the_input(string inputString)
        {
            Assert.Throws<ArgumentException>(() => ArenaParser.Parse(inputString));
        }
    }
}