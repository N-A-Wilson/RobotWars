using RobotWars.Command;

namespace RobotWars
{
    public class EmptyCommand : ICommand
    {
        public CommandType GetCommandType()
        {
            return CommandType.EmptyCommand;
        }

        public void Execute(IRobotCommander commander)
        {
            //do nothing
        }
    }
}