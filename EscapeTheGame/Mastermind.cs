using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace EscapeTheGame
{
    public class Mastermind
    { 
        public Color BackgroundColor = Color.Brown;
        public WorldMap worldMap;
        Window GameWindow;
        public Mastermind(Window window)
        {
            GameWindow = window;
            GameWindow.Width = StaticVariables.WIDTH;
            GameWindow.Height = StaticVariables.HEIGHT;
            GameWindow.BackColor = BackgroundColor;

            worldMap = new WorldMap(StaticVariables.WIDTH,StaticVariables.HEIGHT,GameWindow);
        }
    }
}
