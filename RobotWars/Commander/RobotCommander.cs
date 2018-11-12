using System.Collections.Generic;
using RobotWars.Arenas;
using RobotWars.Robots;

namespace RobotWars
{
    public class RobotCommander : IRobotCommander
    {
        private string commandInput;
        private ICommandParser m_commandParser;
        private List<IRobot> m_battleRobots;
        public Arena Arena { get; set; }

        public RobotCommander(string commandInput)
        {
            this.commandInput = commandInput;
            m_commandParser = new CommandParser();
            m_battleRobots = new List<IRobot>();
        }

        public List<IRobot> GetRobots()
        {
            return m_battleRobots;
        }

        public void AddBattleRobot(BattleRobot battleRobotIn)
        {
            m_battleRobots.Add(battleRobotIn);
        }

        public IRobot GetCurrentRobot()
        {
            if (m_battleRobots?.Count > 0)
            {
                return m_battleRobots[m_battleRobots.Count - 1];
            }

            return null;
        }

        /// <summary>
        /// Gets the position (location and direction) of all robots
        /// </summary>
        /// <returns>A string with one robot position per line of the format "X Y Direction"</returns>
        public string GetRobotPositionOutput()
        {
            string output = "";

            foreach (IRobot robot in m_battleRobots)
            {
                output += robot.GetPosition().ToString()+"\n";
            }

            return output.TrimEnd();
        }

        /// <summary>
        /// Execute the commands
        /// </summary>
        public void ExecuteCommands()
        {
            List<ICommand> commands = m_commandParser.Parse(commandInput);

            foreach (ICommand command in commands)
            {
                command.Execute(this);
            }
        }
        

        
    }
}