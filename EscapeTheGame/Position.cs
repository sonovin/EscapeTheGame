using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeTheGame
{
    public class Position
    {
        public int X;
        public int Y;
        public override bool Equals(object obj)
        {
            return (((Position)obj).X == this.X) && (((Position)obj).Y == this.Y);
        }
    }
}
