using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Classes.weapons
{
    internal class Weapon
    {
        public Weapon(string name, int bonus1, int bonus2, int bonus3, int bonus4d1, int bonus4d2)
        {
            Name = name;
            Bonus1 = bonus1;
            Bonus2 = bonus2;
            Bonus3 = bonus3;
            Bonus4d1 = bonus4d1;
            Bonus4d2 = bonus4d2;
            
        }
        public string Name { get; set; }
        public int Bonus1 { get; set; }
        public int Bonus2 { get; set; }
        public int Bonus3 { get; set; }
        public int Bonus4d1 { get; set; }
        public int Bonus4d2 { get; set; }


        //   weapons(3 types - common, enchanted(+2 bonus prop), rare(+4 bonus prop)):
        //1.Wand(shield avalible) / Staff(twoHanded weapon)(common properties)
        //   - very Low p/ damage
        //   - ManaUp
        //   - IntUp
        //   - *MagicCrit(5 % crt.chanse, 300 % crit.damage)
    }
}
