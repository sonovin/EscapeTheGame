using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace EscapeTheGame
{
    public abstract class Tile
    {
        public string name;
        public abstract Character Affects(Character character);
        public Tile North;
        public Tile South;
        public Tile West;
        public Tile East;
        public ObjectModel Occupy;
        public PictureBox Display = new PictureBox
        {
            Width = StaticVariables.TILE_SIZE,
            Height = StaticVariables.TILE_SIZE
        };

    }
}
