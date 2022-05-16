using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskine1
{
    class WaterContainer
    {
        private int water;

        public int Water
        {
            get { return water; }
            set { water = value; }
        }

        public void AddWater(int addWater)
        {
            water = addWater;
        }

        public void RemoveWater()
        {
            water = 0;
        }
    }
}
