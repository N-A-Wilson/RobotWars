using System;
using NUnit.Framework;
using RobotWars.Arenas;

namespace RobotWarsTests
{
    [TestFixture]
    public class ArenaTests
    {
        [TestCase(5, 5, TestName = "5x5")]
        [TestCase(0, 0, TestName = "Empty Grid")]
        public void CreateArenaTests(int width, int height)
        {
            IArena arena = new Arena(width, height);

            Assert.AreEqual(width, arena.Dimensions.Width);
            Assert.AreEqual(height, arena.Dimensions.Height);
        }

        [TestCase(5, 5, 1, 2, TestName = "Point (1,2) in a 5x5 arena")]
        [TestCase(5, 5, 3, 3, TestName = "Point (3,3) in a 5x5 arena")]
        public void ValidPointsAreValidTests(int width, int height, int x, int y)
        {
            IArena arena = new Arena(width, height);

            Assert.True(arena.IsValid(x, y));
        }


        [TestCase(5, 5, 7, 2, TestName = "Point (7,2) in a 5x5 arena")]
        [TestCase(5, 5, 3, 8, TestName = "Point (3,8) in a 5x5 arena")]
        [TestCase(5, 5, -1, 3, TestName = "Point (-1,3) in a 5x5 arena")]
        [TestCase(5, 5, 1, -2, TestName = "Point (1,-2) in a 5x5 arena")]
        public void InvalidPointsAreNotValidTests(int width, int height, int x, int y)
        {
            IArena arena = new Arena(width, height);

            Assert.False(arena.IsValid(x, y));
        }
    }
}
