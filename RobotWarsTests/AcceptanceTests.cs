using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using RobotWars;
using RobotWars.Robots;

namespace RobotWarsTests
{
    [TestFixture]
    public class AcceptanceTests 
    {
        [TestCase("5 5", 5, 5, TestName = "5x5 (From Spec)")]
        [TestCase("7 4", 7, 4, TestName = "7x4 (Non-Square)")]
        public void CreateInitialArenaTests(string commandInput, int expectedWidth, int expectedHeight)
        {
            IRobotCommander robotCommander = new RobotCommander(commandInput);
            robotCommander.ExecuteCommands();
            

            Assert.AreEqual(expectedWidth, robotCommander.Arena.Dimensions.Width);
            Assert.AreEqual(expectedHeight, robotCommander.Arena.Dimensions.Height);
        }

        [TestCase("1 2 N", 1, 2, Direction.N, TestName = "Facing North at (1,2)")]
        [TestCase("3 3 E", 3, 3, Direction.E, TestName = "Facing East at (3, 3)")]
        public void PlaceRobotCorrectlyTests(string commandInput, int expectedX, int expectedY, Direction expectedDirection)
        {
            IRobotCommander robotCommander = new RobotCommander(commandInput);
            robotCommander.ExecuteCommands();
            List<IRobot> robots = robotCommander.GetRobots();
            Position position = robots[0].GetPosition();

            Assert.AreEqual(expectedX, position.X);
            Assert.AreEqual(expectedY, position.Y);
            Assert.AreEqual(expectedDirection, position.Direction);
        }

        [TestCase("LMLMLMLMM", 1, 2, Direction.N, 1, 3, Direction.N, TestName = "First Input Test")]
        [TestCase("MMRMMRMRRM", 3, 3, Direction.E, 5, 1, Direction.E, TestName = "Second Input Test")]
        public void RobotsMoveToCorrectLocationTests(string commandInput,int initialX, int initialY, Direction initialDirection, int expectedX, int expectedY, Direction expectedDirection)
        {
            IRobotCommander robotCommander = new RobotCommander(commandInput);
            robotCommander.AddBattleRobot(new BattleRobot(initialX, initialY, initialDirection));

            robotCommander.ExecuteCommands();
            List<IRobot> robots = robotCommander.GetRobots();
            Position position = robots[0].GetPosition();

            Assert.AreEqual(expectedX, position.X);
            Assert.AreEqual(expectedY, position.Y);
            Assert.AreEqual(expectedDirection, position.Direction);
        }

        [Test]
        public void FullInputTest()
        {
            string commandInput = BuildTestInput();
            string expectedOutput = "1 3 N\n5 1 E";
            IRobotCommander robotCommander = new RobotCommander(commandInput);
            robotCommander.ExecuteCommands();

            string result = robotCommander.GetRobotPositionOutput();
            Assert.AreEqual(expectedOutput, result);
        }

        private static string BuildTestInput()
        {
            StringBuilder input = new StringBuilder();
            input.AppendLine("5 5");
            input.AppendLine("1 2 N");
            input.AppendLine("LMLMLMLMM");
            input.AppendLine("3 3 E");
            input.Append("MMRMMRMRRM");

            return input.ToString();
        }
    }
}
