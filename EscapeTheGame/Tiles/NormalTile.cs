using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EscapeTheGame.Tiles
{
    public class NormalTile: Tile
    {
        public NormalTile(Position p)
        {
            name = "Normal";
            Display.BackColor = Color.LightYellow;
            Display.Location = new Point(p.X * StaticVariables.TILE_SIZE, p.Y * StaticVariables.TILE_SIZE);
        }
        public override Character Affects(Character character)
        {
            return character;
        }
    }
}
