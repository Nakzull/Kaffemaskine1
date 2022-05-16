using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskine1
{
    class CoffeeMachine : Appliance
    {
        WaterContainer watercontainer = new WaterContainer();
        CoffeeContainer coffeeContainer = new CoffeeContainer();

        private int cupsOfCoffee;
        
        public int CupsOfCoffee
        {
            get { return cupsOfCoffee; }
            set { cupsOfCoffee = value; }
        }

        public void EmptyCoffee()
        {
            CupsOfCoffee = 0;
        }
        public void MakeCoffee()
        {
            int water = watercontainer.Water;
            CupsOfCoffee = water / 200;
            Console.WriteLine("Made a total of " + CupsOfCoffee + " cup(s) of coffee");
            watercontainer.Water = 0;
            coffeeContainer.CoffeePowder = 0;
        }

        public void AddWater(int addWater)
        {
            watercontainer.AddWater(addWater);
        }

        public void RemoveFilter()
        {
            coffeeContainer.RemoveFilter();
        }

        public void AddFilter()
        {
            coffeeContainer.AddFilter();
        }
        public void AddCoffeePowder(double coffeegram)
        {
            coffeeContainer.AddCoffeePowder(coffeegram);
        }

        public override void PowerOn()
        {
            if (coffeeContainer.Filter == true)
            {
                if (watercontainer.Water > 0)
                {
                    if (coffeeContainer.CoffeePowder > 0)
                    {
                        MakeCoffee();
                    }
                    else
                        Console.WriteLine("Please add coffee powder first");
                }
                else
                    Console.WriteLine("Please add water first");
            }
            else
                Console.WriteLine("Please add a filter first");
        }
    }
}
