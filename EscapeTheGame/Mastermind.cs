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
        public int Width = 800;
        public int Height = 800;
        public Color BackgroundColor = Color.Brown;
        Window GameWindow;
        public Mastermind(Window window)
        {
            GameWindow = window;
            GameWindow.Width = Width;
            GameWindow.Height = Height;
            GameWindow.BackColor = BackgroundColor;
        }
    }
}
