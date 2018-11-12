namespace RobotWars.Robots
{
    public class BattleRobot : IRobot
    {

        private Position m_position;

        public BattleRobot(int xIn, int yIn, Direction directionIn)
        {
            m_position = new Position(xIn, yIn, directionIn);
        }

        /// <summary>
        /// Gets the current position of the robot
        /// </summary>
        /// <returns>The position (location and direction) of the robot</returns>
        public Position GetPosition()
        {
            return m_position;
        }

        /// <summary>
        /// Turn the Robot left
        /// </summary>
        public void TurnLeft()
        {
            switch (m_position.Direction)
            {
                case Direction.N:
                    m_position.Direction = Direction.W;
                    break;
                case Direction.W:
                    m_position.Direction = Direction.S;
                    break;
                case Direction.S:
                    m_position.Direction = Direction.E;
                    break;
                case Direction.E:
                    m_position.Direction = Direction.N;
                    break;
            }
        }

        //Turn the robot right
        public void TurnRight()
        {
            switch (m_position.Direction)
            {
                case Direction.N:
                    m_position.Direction = Direction.E;
                    break;
                case Direction.W:
                    m_position.Direction = Direction.N;
                    break;
                case Direction.S:
                    m_position.Direction = Direction.W;
                    break;
                case Direction.E:
                    m_position.Direction = Direction.S;
                    break;
            }
        }

        /// <summary>
        /// Moves the robot one step in the direction it's facing. Assumes that the new space exists
        /// </summary>
        public void MoveForward()
        {
            switch (m_position.Direction)
            {
                case Direction.N:
                    m_position.Y++;
                    break;
                case Direction.E:
                    m_position.X++;
                    break;
                case Direction.S:
                    m_position.Y--;
                    break;
                case Direction.W:
                    m_position.X--;
                    break;
            }
        }
    }
}
