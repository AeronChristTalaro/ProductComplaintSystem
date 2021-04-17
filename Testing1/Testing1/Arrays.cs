using System;
using System.Collections.Generic;
using System.Text;

namespace Testing1
{
    class Arrays
    {
        string[] food = new string[] { "", "1.Meat", "2.Poultry", "3.Beef" };
        string[] drinks = new string[] { "", "1.Soda", "2.Water", "3.Juice" };

        public void foodArray()
        {
            for (int i = 0;i<5; i++)
            Console.WriteLine(food[i]);

        }
        public void drinksArray()
        {
            for (int i = 0; i < 5; i++)
                Console.WriteLine(drinks[i]);

        }
    }
}
