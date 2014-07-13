using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeTheGame
{
    public class Speciality
    {
        public enum Special
        {
            Strength = 0,
            Intelligence = 1,
            Dexterity = 2,
            Vitality = 3,
            Wisdom = 4,
            Luck = 5
        };
        public Special Effect;
        public double Magnitude;
    }
}
