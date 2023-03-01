using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOneTextAdventure
{
    public class BossNPC
    {
        private int health = 50;
        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        private int armour = 5;

        public int Armour
        {
            get { return armour; }
            set { armour = value; }
        }
    }
}
