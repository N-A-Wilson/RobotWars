namespace RobotWars.Robots
{
    public struct Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Direction Direction { get; set; }


        public Position(int xIn, int yIn, Direction directionIn) : this()
        {
            X = xIn;
            Y = yIn;
            Direction = directionIn;
        }

        public override string ToString()
        {
            return string.Format("{0}{1}{2}{1}{3}", X, CommandParser.INSTRUCTION_SEPERATOR, Y, Direction);
        }
    }
}
