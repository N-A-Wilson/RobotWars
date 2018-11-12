using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars.Arenas
{
    public struct Dimensions
    {
        public int Width;
        public int Height;

        public Dimensions(int widthIn, int heightIn)
        {
            Width = widthIn;
            Height = heightIn;
        }
    }
}
