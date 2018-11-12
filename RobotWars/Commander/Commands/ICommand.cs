using RobotWars.Command;

namespace RobotWars
{
    public interface ICommand
    {
        CommandType GetCommandType();
        void Execute(IRobotCommander commander);
    }
}