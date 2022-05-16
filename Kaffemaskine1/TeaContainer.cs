using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskine1
{
    class TeaContainer
    {
        private bool teabag;

        public bool Teabag
        {
            get { return teabag; }
            set { teabag = value; }
        }

        public void AddTeabag()
        {
            teabag = true;
        }

        public void RemoveTeabag()
        {
            teabag = false;
        }
    }
}
