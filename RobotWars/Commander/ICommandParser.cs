using System.Collections.Generic;

namespace RobotWars
{
    public interface ICommandParser
    {
        List<ICommand> Parse(string commandInput);
    }
}