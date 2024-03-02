using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Classes.armors
{
    internal class Armor
    {
        public Armor(string name, int armorunit, int durability)
        {
            Name = name;
            ArmorUnit = armorunit;
            Durability = durability;
        }
        public int ArmorUnit { get; set; }
        public int Durability { get; set;}
        public string Name { get; set; }
    }
}
