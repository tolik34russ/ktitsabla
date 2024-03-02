using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Unit    
    {
        public Unit()
        {
        }

        public Unit(int strenght, int dexterity, int intelengence, int vitality,
                    int maxstrenght, int maxdexterity, int maxintelengence, int maxvitality,
                    int health, int mana, int pdamage, int armor, int mdamage, int mdefense,
                    int crtchanse, int crtdamage, int level, int exp, string name, int totalExp, List<string> equipment)
        {
            Strenght = strenght;
            Dexterity = dexterity;
            Intelengence = intelengence;
            Vitality = vitality;
            Health = health;
            Mana = mana;
            Pdamage = pdamage;
            Armor = armor;
            Mdamage = mdamage;
            Mdefense = mdefense;
            Crtchanse = crtchanse;
            Crtdamage = crtdamage;
            MaxStrenght = maxstrenght;
            MaxDexterity = maxdexterity;
            MaxIntelengence = maxintelengence;
            MaxVitality = maxvitality;           
            Level = level;
            Exp = exp;
            Name = name;
            TotalExp = totalExp;
            Equipment = equipment;
        }
        public int Strenght { get; set; }
        public int Dexterity { get; set; }
        public int Intelengence { get; set; }
        public int Vitality { get; set; }
        public int MaxStrenght { get; set; }
        public int MaxDexterity { get; set; }
        public int MaxIntelengence { get; set; }
        public int MaxVitality { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Pdamage { get; set; }
        public int Armor { get; set; }
        public int Mdamage { get; set; }
        public int Mdefense { get; set; }
        public int Crtchanse { get; set; }
        public int Crtdamage { get; set; }     
        public int Level { get; set; }
        public int Exp { get; set; }
        public string Name { get; set; }
        public int TotalExp { get; set; }
        public List<string> Equipment { get; set; }

}
}
