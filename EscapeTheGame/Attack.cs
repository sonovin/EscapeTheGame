using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeTheGame
{
    public abstract class Attack
    {
        public List<Attribute> Properties;
        public List<Speciality> StatIncreaseForMove;
        public string Name;
        public abstract Character Strike(Character affectedChar);
    }
}
