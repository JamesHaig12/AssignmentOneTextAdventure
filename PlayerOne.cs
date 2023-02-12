using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOneTextAdventure
{
    public class PlayerOne
    {
        private int health = 20;
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
    }
}
