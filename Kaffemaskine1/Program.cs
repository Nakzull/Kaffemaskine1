using System;

namespace Kaffemaskine1
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachine coffeeMachine = new CoffeeMachine();
            int choice;
            while (true)
            {
                Console.WriteLine("1. Add water\n2. Empty coffee container\n3. Remove filter\n4. Add filter\n5. Add coffee powder\n6. Turn on machine\n7. Turn off machine\n8. Add teabag\n9. Remove teabag\n10. Insert espresso pack");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    bool keepRunning = true;
                    while (keepRunning)
                    {
                        Console.WriteLine("How much water are you adding(mililiter, 1-1250)?");
                        int water = Convert.ToInt32(Console.ReadLine());
                        if (water < 1250 && water > 0)
                        {
                            coffeeMachine.AddWater(water);
                            keepRunning = false;
                        }
                        else
                            Console.WriteLine("Please select a valid amount (1-1250)");
                    }
                }
                else if (choice == 2)
                {
                    coffeeMachine.EmptyCoffee();
                }
                else if (choice == 3)
                {
                    coffeeMachine.RemoveFilter();
                }
                else if (choice == 4)
                {
                    coffeeMachine.AddFilter();
                }
                else if (choice == 5)
                {                   
                    bool keepRunning = true;
                    while (keepRunning)
                    {
                        Console.WriteLine("How much coffee do you wanna add(grams)?");
                        double coffee = Convert.ToDouble(Console.ReadLine());
                        if (coffee > 0)
                        {
                            coffeeMachine.AddCoffeePowder(coffee);
                            keepRunning = false;
                        }
                        else
                            Console.WriteLine("Please select a valid amount");
                    }
                }
                else if (choice == 6)
                {
                    coffeeMachine.PowerOn();
                }
                else if (choice == 7)
                {
                    coffeeMachine.PowerOff();
                }
                else if (choice == 8)
                {
                    coffeeMachine.AddTeabag();
                }
                else if (choice == 9)
                {
                    coffeeMachine.RemoveTeabag();
                }
                else if (choice == 10)
                {
                    coffeeMachine.InsertEspresso();
                }
                else
                    Console.WriteLine("Please choose a valid option");
            }
        }
    }
}
