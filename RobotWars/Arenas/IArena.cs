namespace RobotWars.Arenas
{
    public interface IArena
    {


        bool IsValid(int x, int y);
        Dimensions Dimensions { get; }
    }
}