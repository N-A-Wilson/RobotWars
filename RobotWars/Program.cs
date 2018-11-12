using System;
using System.Text;

namespace RobotWars
{
    static class Program
    {
        static void Main()
        {
            string testInput = BuildTestInput();
            Console.WriteLine("Input:");
            Console.WriteLine(testInput);
            Console.WriteLine("=============================");
            IRobotCommander commander = new RobotCommander(testInput);
            commander.ExecuteCommands();
            string output = commander.GetRobotPositionOutput();
            Console.WriteLine("Output:");
            Console.WriteLine(output);
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }

        private static string BuildTestInput()
        {
            StringBuilder input = new StringBuilder();
            input.AppendLine("5 5");
            input.AppendLine("1 2 N");
            input.AppendLine("LMLMLMLMM");
            input.AppendLine("3 3 E");
            input.Append("MMRMMRMRRM");

            return input.ToString();
        }
    }
}
