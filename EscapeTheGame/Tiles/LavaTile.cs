using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace EscapeTheGame.Tiles
{
    public class LavaTile: Tile
    {
        public LavaTile(Position p)
        {
            name = "Lava";
            Display.BackColor = Color.OrangeRed;
            Display.Location = new Point(p.X * StaticVariables.TILE_SIZE, p.Y * StaticVariables.TILE_SIZE);
        }
        public override Character Affects(Character character)
        {
            //TODO: Need to check the list and increment the attribute accordingly
            //var status = character.Status.Where(attribute => attribute.Effect == Attributes.Attribute.BURNING).ToList();
            
            character.Status.Add(new Attributes(Attributes.Attribute.BURNING, 1));
            return character;
        }
    }
}
