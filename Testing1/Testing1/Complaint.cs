using System;
using System.Collections.Generic;
using System.Text;

namespace Testing1
{
    class Complaint
    {

        string[] food = new string[] { "", "1.Meat", "2.Poultry", "3.Beef" };
        string[] drinks = new string[] { "", "1.Soda", "2.Water", "3.Juice" };


        public void cdata()
        {   
            Console.WriteLine("                   *Welcome to Complaint Form*");
            Console.WriteLine("             *Please answer the questions correctly*");

            Console.Write("Enter Name: ");
            string cName = Console.ReadLine();
            Console.Write("Enter Age: ");
            int cAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Cellphone No#: ");
            string cNum = Console.ReadLine();
            Console.Write("Enter Email Address: ");
            string cEmail = Console.ReadLine();

            Console.WriteLine("-----------------------");
            Console.WriteLine("Find the product you have complaints:");
            Console.WriteLine("Category of Products");
            Console.WriteLine("");
            Console.WriteLine("1.Food   2. Drinks");
            Console.WriteLine("");
            Console.Write("No# of category you like to see:");
            int product = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--Product List--");
            if (product == 1)
            {
                for (int i = 0; i < 4; i++)
                {

                    Console.WriteLine(food[i]);
                }

                Console.WriteLine("Enter the food you have complaints: ");
                string cProduct = Console.ReadLine();
                Console.WriteLine("Pls Indicate the Complain issue you have: ");
                string complains = Console.ReadLine();

                Console.WriteLine("");
                Console.WriteLine("Finalizing");
                Console.WriteLine("");
                Console.WriteLine("Complainants Name: " + cName);
                Console.WriteLine("Complainants Age: " + cAge);
                Console.WriteLine("Complainants Number: " + cNum);
                Console.WriteLine("Complainants Email: " + cEmail);
                Console.WriteLine("Product Issue: " + cProduct);
                Console.WriteLine("Product Complains: " + complains);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("*Thank you*\n*We'll send you a feedback regarding your complain as soon as possible*");
                
                


            }
            else if (product == 2)
            {
                for (int i = 0; i < 4; i++)
                {

                    Console.WriteLine(drinks[i]);
                }
                Console.WriteLine("Enter the drinks you have complaints: ");
                string cProduct = Console.ReadLine();
                Console.WriteLine("Pls Indicate the Complain issue you have: ");
                string complains = Console.ReadLine();

                Console.WriteLine("");
                Console.WriteLine("Finalizing");
                Console.WriteLine("");
                Console.WriteLine("Complainants Name: " + cName);
                Console.WriteLine("Complainants Age: " + cAge);
                Console.WriteLine("Complainants Number: " + cNum);
                Console.WriteLine("Complainants Email: " + cEmail);
                Console.WriteLine("Complainants Product Issue: " + cProduct);
                Console.WriteLine("Complainants Product Issue: " + complains);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("*Thank you*\n *We'll send you a feedback regarding your complain as soon as possible*");










            }
            else
            {
                Console.WriteLine("Error Category is Up to 1 and to 2 only");
                return;
            }

        }

    }
}
