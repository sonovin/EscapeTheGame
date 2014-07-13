using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeTheGame
{
    public abstract class Tile
    {
        public string name;
        public abstract void Affects(Character character);
        public Tile North;
        public Tile South;
        public Tile West;
        public Tile East;
        public ObjectModel Occupy;
    }
}
