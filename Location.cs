using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOneTextAdventure
{
    public class Location
    {
        Random rnd = new Random();
        private int numEnemies;
        public int Enemies
        {
            get { return numEnemies; }
            set { numEnemies = value; }
        }

        public Location()
        {
            numEnemies = rnd.Next(1, 10);
        }
    }
}
