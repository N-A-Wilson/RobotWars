using RobotWars.Arenas;

namespace RobotWars.Command
{
    internal class ArenaCommand : ICommand
    {
        private int width;
        private int height;
      

        public ArenaCommand(int widthIn, int heightIn)
        {
            width = widthIn;
            height = heightIn;
            
        }

        public CommandType GetCommandType()
        {
            return CommandType.ArenaCommand;
        }

        public void Execute(IRobotCommander commander)
        {
            commander.Arena = new Arena(width, height);
        }
    }
}
