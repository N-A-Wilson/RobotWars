using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using RobotWars;
using NUnit.Framework;
using RobotWars.Command;

namespace RobotWarsTests
{
    [TestFixture]
    public class CommandParserTests
    {
        [TestCase("5 5")]
        [TestCase("7 4")]
        public void ParseArenaCommandsTest(string commandInput)
        {
            ICommandParser parser = new CommandParser();
            List<ICommand> commands = parser.Parse(commandInput);

            Assert.AreEqual(CommandType.ArenaCommand, commands[0].GetCommandType());
        }
        
        [TestCase("1 2 N", TestName = "First placement")]
        [TestCase("3 3 E", TestName = "Second placement")]
        public void ParsePlaceRobotCommandsTest(string commandInput)
        {
            ICommandParser parser = new CommandParser();
            List<ICommand> commands = parser.Parse(commandInput);

            Assert.AreEqual(CommandType.PlaceRobotCommand, commands[0].GetCommandType());
        }

        [TestCase("LMLMLMLMM", TestName = "First Movement")]
        [TestCase("MMRMMRMRRM", TestName = "Second Movement")]
        public void ParseMoveRobotCommandTests(string commandInput)
        {
            ICommandParser parser = new CommandParser();
            List<ICommand> commands = parser.Parse(commandInput);

            Assert.AreEqual(CommandType.MoveRobotCommand, commands[0].GetCommandType());
        }
    }
}
