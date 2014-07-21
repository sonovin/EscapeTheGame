using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeTheGame
{
    public class Attributes
    {
        public enum Attribute
        {
            KO = -1,
            NONE = 0,
            BURNING = 1,
            FROST_BITE = 2,
            PARALYSIS = 3,
            POISON = 4,
            BLIND = 5
        };
        public Attribute Effect;
        //By Turns
        public int Duration;

        public Attributes(Attribute effect, int duration)
        {
            Effect = effect;
            Duration = duration;
        }
    }
}
