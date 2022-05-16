using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskine1
{
    class CoffeeMachine : Appliance
    {
        WaterContainer watercontainer = new WaterContainer();
        CoffeeContainer coffeeContainer = new CoffeeContainer();
        TeaContainer teaContainer = new TeaContainer();

        private int cupsOfCoffee;
        
        public int CupsOfCoffee
        {
            get { return cupsOfCoffee; }
            set { cupsOfCoffee = value; }
        }

        private int cupsOfTea;

        public int CupsOfTea
        {
            get { return cupsOfTea; }
            set { cupsOfTea = value; }
        }

        private bool espresso;

        public bool Espresso
        {
            get { return espresso; }
            set { espresso = value; }
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
        public void MakeTea()
        {
            int water = watercontainer.Water;
            CupsOfTea = water / 200;
            watercontainer.Water = 0;
        }

        public void MakeEspresso()
        {
            watercontainer.Water -= 200;
            Espresso = false;
            Console.WriteLine("Made one cup of espresso");
        }

        public void InsertEspresso()
        {
            Espresso = true;
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
            if (espresso == true)
            {
                if (watercontainer.Water >= 200)
                {
                    MakeEspresso();
                }
                else
                    Console.WriteLine("Please add water");
            }
            else if (teaContainer.Teabag == true)
            {
                if (watercontainer.Water > 0)
                {
                    MakeTea();
                }
                else
                    Console.WriteLine("Please add water");
            }
            else if (coffeeContainer.Filter == true)
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

        public void AddTeabag()
        {
            teaContainer.AddTeabag();
        }
        public void RemoveTeabag()
        {
            teaContainer.RemoveTeabag();
        }
    }
}
