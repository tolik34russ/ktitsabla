using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Classes.weapons
{
    internal class Weapon
    {
        public Weapon(string id, string name, string rarity, int damage, int cc, int cd)
        {
            Id = id;
            Name = name;
            Damage = damage;
            Cc = cc;
            Cd = cd;
            Rarity = rarity;
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Cc { get; set; }
        public int Cd { get; set; }
        public string Rarity { get; set; }
    }
}
