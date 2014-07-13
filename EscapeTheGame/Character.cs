using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeTheGame
{
    public class Character : ObjectModel
    {
        public int Level;
        public string Name;
        public string Description;
        public List<Attributes> Status;
        public Position Location;
        public Item ItemHeld;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        public int Vitality;
        public int Wisdom;
        public int Luck;
    }
}
