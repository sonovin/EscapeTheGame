using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeTheGame
{
    public class Item
    {
        //Items will have this field to indicate their source of origin, once they fuse and come back to the item they have spawn as they will get upgraded with an extra attribute
        public string SpawnAs;
        public Dictionary<string, string> PossibleFusions;
        public List<Speciality> specialities;
    }
}
