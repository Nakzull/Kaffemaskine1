using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskine1
{
    class CoffeeContainer
    {
        private double coffeePowder;

        public double CoffeePowder
        {
            get { return coffeePowder; }
            set { coffeePowder = value; }
        }

        private bool filter;

        public bool Filter
        {
            get { return filter; }
            set { filter = value; }
        }

        public void AddCoffeePowder(double coffeeGram)
        {
            coffeePowder = coffeeGram;
        }

        public void AddFilter()
        {
            filter = true;
        }

        public void RemoveFilter()
        {
            filter = false;
            coffeePowder = 0;
        }
    }
}
