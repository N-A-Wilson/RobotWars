using System;
using NUnit.Framework;
using RobotWars.Robots;

namespace RobotWarsTests
{
    [TestFixture]
    public class PositionTests
    {
        [TestCase(1, 2, Direction.N, "1 2 N", TestName = "1 2 N")]
        [TestCase(5, 1, Direction.E, "5 1 E", TestName = "5 1 E")]
        public void PositionToStringTests(int x, int y, Direction direction, string expectedString)
        {
            Position position = new Position(x, y, direction);

            Assert.AreEqual(expectedString, position.ToString());
        }
    }
}
