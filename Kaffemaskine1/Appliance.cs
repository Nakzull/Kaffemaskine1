using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskine1
{
    public abstract class Appliance
    {
        private bool power;

        public bool Power
        {
            get { return power; }
            set { power = value; }
        }

        public virtual void PowerOn()
        {
            power = true;
        }

        public void PowerOff()
        {
            power = false;
        }
    }
}
