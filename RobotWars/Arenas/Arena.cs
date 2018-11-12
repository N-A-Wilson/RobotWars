namespace RobotWars.Arenas
{
    public class Arena : IArena
    {
        public Dimensions Dimensions { get; }

        public Arena(int widthIn, int heightIn)
        {
            Dimensions = new Dimensions(widthIn, heightIn);
        }


        /// <summary>
        /// Test if a given point is within the bounds of the arena
        /// </summary>
        /// <param name="x">the x coordinate</param>
        /// <param name="y">the y coordinate</param>
        /// <returns>True if the point is valid, false otherwise</returns>
        public bool IsValid(int x, int y)
        {
            return x < Dimensions.Width && x >= 0 && y < Dimensions.Height && y >= 0;
        }
    }
}
