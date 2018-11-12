using System.Collections.Generic;
using RobotWars.Arenas;
using RobotWars.Robots;

namespace RobotWars
{
    public interface IRobotCommander
    {
        void ExecuteCommands();
        Arena Arena { get; set; }

        List<IRobot> GetRobots();
        void AddBattleRobot(BattleRobot battleRobot);
        IRobot GetCurrentRobot();
        string GetRobotPositionOutput();
    }
}
