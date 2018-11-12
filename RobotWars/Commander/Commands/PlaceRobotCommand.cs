using RobotWars.Command;
using RobotWars.Robots;

namespace RobotWars
{
    internal class PlaceRobotCommand : ICommand
    {
        private int m_x;
        private int m_y;
        private Direction m_direction;
        public PlaceRobotCommand(int xIn, int yIn, Direction directionIn)
        {
            m_x = xIn;
            m_y = yIn;
            m_direction = directionIn;
        }

        public CommandType GetCommandType()
        {
            return CommandType.PlaceRobotCommand;
        }

        public void Execute(IRobotCommander commander)
        {
            commander.AddBattleRobot(new BattleRobot(m_x, m_y, m_direction));
        }
    }
}