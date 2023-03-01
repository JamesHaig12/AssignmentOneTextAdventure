using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOneTextAdventure
{
    public class PlayerOne
    {
        private int health = 40;
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        private int mana = 40;
        public int Mana
        {
            get { return mana; }
            set { mana = value; }
        }
        private int stamina = 40;
        public int Stamina
        {
            get { return stamina; }
            set { stamina = value; }
        }
        private int armour = 0;
        public int Armour
        {
            get { return armour; }
            set { armour = value; }
        }

        private int damageBuff = 0;
        public int DamageBuff
        {
            get { return damageBuff; }
            set { damageBuff = value; }
        }

        private static int location;
        public static int Location
        {
            get { return location; }
            set { location = value; }
        }
    }
}
