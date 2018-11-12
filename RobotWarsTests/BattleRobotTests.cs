using NUnit.Framework;
using RobotWars.Robots;

namespace RobotWarsTests
{
    [TestFixture]
    public class BattleRobotTests
    {
        [TestCase(1, 2, Direction.N, TestName = "Facing North at (1,2)")]
        [TestCase(3, 3, Direction.E, TestName = "Facing East at (3, 3)")]
        public void CreateBattleRobotTests(int x, int y, Direction direction)
        {
            IRobot robot = new BattleRobot(x, y, direction);

            Position position = robot.GetPosition();

            Assert.AreEqual(x, position.X);
            Assert.AreEqual(y, position.Y);
            Assert.AreEqual(direction, position.Direction);
        }

        [TestCase(Direction.N, Direction.W, TestName = "From North")]
        [TestCase(Direction.W, Direction.S, TestName = "From West")]
        [TestCase(Direction.S, Direction.E, TestName = "From South")]
        [TestCase(Direction.E, Direction.N, TestName = "From East")]
        public void TurnRobotLeftTests(Direction initialDirection, Direction expectedDirection)
        {
            IRobot robot = new BattleRobot(0, 0, initialDirection);

            robot.TurnLeft();

            Assert.AreEqual(expectedDirection, robot.GetPosition().Direction);
        }

        [TestCase(Direction.N, Direction.E, TestName = "Right From North")]
        [TestCase(Direction.E, Direction.S, TestName = "Right From East")]
        [TestCase(Direction.S, Direction.W, TestName = "Right From South")]
        [TestCase(Direction.W, Direction.N, TestName = "Right From West")]
        public void TurnRobotRightTests(Direction initialDirection, Direction expectedDirection)
        {
            IRobot robot = new BattleRobot(0, 0, initialDirection);

            robot.TurnRight();

            Assert.AreEqual(expectedDirection, robot.GetPosition().Direction);
        }

        [TestCase(2, 2, Direction.N, 2, 3, TestName = "Move North")]
        [TestCase(2, 2, Direction.E, 3, 2, TestName = "Move East")]
        [TestCase(2, 2, Direction.S, 2, 1, TestName = "Move South")]
        [TestCase(2, 2, Direction.W, 1, 2, TestName = "Move West")]
        public void MoveRobotTests(int initialX, int initialY, Direction direction, int expectedX, int expectedY)
        {
            IRobot robot = new BattleRobot(initialX, initialY, direction);

            robot.MoveForward();

            Position positon = robot.GetPosition();

            Assert.AreEqual(expectedX, positon.X);
            Assert.AreEqual(expectedY, positon.Y);
        }
    }
}
