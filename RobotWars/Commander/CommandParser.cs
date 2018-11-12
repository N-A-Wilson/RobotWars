using System;
using System.Collections.Generic;
using RobotWars.Command;
using RobotWars.Robots;

namespace RobotWars
{
    public class CommandParser : ICommandParser
    {
        public const char INSTRUCTION_SEPERATOR = ' ';
        public const char COMMAND_SEPERATOR = '\n';

        /// <summary>
        /// Parse a multi-line command input
        /// </summary>
        /// <param name="commandInput">the string commands to parse</param>
        /// <returns>The list of commands parsed from commandInput</returns>
        public List<ICommand> Parse(string commandInput)
        {
            List<ICommand> commands = new List<ICommand>();
            string[] stringCommands = commandInput.Split(COMMAND_SEPERATOR);

            foreach (string stringCommand in stringCommands)
            {
                commands.Add(IdentifyAndParse(stringCommand));
            }

            return commands;
        }

        /// <summary>
        /// Identifies the type of command provided and parses it into a command
        /// </summary>
        /// <param name="stringCommand">The command to identify and parse</param>
        /// <returns>The resulting command</returns>
        public ICommand IdentifyAndParse(string stringCommand)
        {
            string[] commandParams = stringCommand.Trim().Split(INSTRUCTION_SEPERATOR);
            switch (commandParams.Length)
            {
                case 1:
                    return ParseRobotMovementCommands(commandParams[0]);
                case 2:
                    return ParseArenaCommand(commandParams);
                case 3:
                    return ParsePlaceRobotCommand(commandParams);
                    default:
                        return new EmptyCommand();
            }

        }

        private ICommand ParseRobotMovementCommands(string commandParams)
        {
            List<Movement> moves = new List<Movement>();

            foreach (char command in commandParams)
            {
                Movement move;
                Enum.TryParse(command.ToString(), out move);
                moves.Add(move);
            }

            return new MoveRobotCommand(moves);
        }

        private ICommand ParsePlaceRobotCommand(string[] commandParams)
        {
            int x;
            int y;
            Direction direction;

            int.TryParse(commandParams[0], out x);
            int.TryParse(commandParams[1], out y);
            Enum.TryParse(commandParams[2], out direction);

            return new PlaceRobotCommand(x, y, direction);
        }

        private ICommand ParseArenaCommand(string[] dimensions)
        {
            int width;
            int height;
            
            int.TryParse(dimensions[0], out width);
            int.TryParse(dimensions[1], out height);

            return new ArenaCommand(width, height);
        }
    }
}