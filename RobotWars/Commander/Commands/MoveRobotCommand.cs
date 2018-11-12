using System;
using System.Collections.Generic;
using RobotWars.Command;
using RobotWars.Robots;

namespace RobotWars
{
    public class MoveRobotCommand : ICommand
    {
        private List<Movement> m_moves;

        public MoveRobotCommand(List<Movement> movesIn)
        {
            m_moves = new List<Movement>();
            m_moves.AddRange(movesIn);
        }

        public CommandType GetCommandType()
        {
            return CommandType.MoveRobotCommand;
        }

        public void Execute(IRobotCommander commander)
        {
            IRobot robot = commander.GetCurrentRobot();
            foreach (Movement m in m_moves)
            {
                switch (m)
                {
                    case Movement.L:
                        robot.TurnLeft();
                        break;
                    case Movement.R:
                        robot.TurnRight();
                        break;
                    case Movement.M:
                        robot.MoveForward();
                        break;
                }
            }
        }
    }
}