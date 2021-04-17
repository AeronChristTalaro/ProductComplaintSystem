using System;
using System.Collections.Generic;
using System.Text;

namespace Testing1
{
    class User

    {
        string[] food = new string[] { "", "1.Meat", "2.Poultry", "3.Beef" };
        string[] drinks = new string[] { "", "1.Soda", "2.Water", "3.Juice" };


        public void use()
        {
            Console.WriteLine("             *Welcome to Product Complaint System*");
            Console.WriteLine("                         Good Day");

            Console.WriteLine("");
            Console.WriteLine("Product List:");
            Console.WriteLine("1.Food   2. Drinks");
            Console.WriteLine("");
            Console.Write("No# of category you like to see:");
            int product = Convert.ToInt32(Console.ReadLine());

            if (product == 1)
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine(food[i]);
                }
            }
            else if (product == 2)
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine(drinks[i]);
                }

            }
          




        }
    }
}
