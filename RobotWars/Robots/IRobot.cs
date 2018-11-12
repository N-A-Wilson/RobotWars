namespace RobotWars.Robots
{
    public interface IRobot
    {
        Position GetPosition();

        void TurnLeft();
        void TurnRight();
        void MoveForward();
    }
}
