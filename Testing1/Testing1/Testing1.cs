using System;
using System.Collections.Generic;
using System.Text;

namespace Testing1
{
    class Testing1:Arrays

    {

        
        


        string[] food = new string[] { "", "1.Meat", "2.Poultry", "3.Beef" };
        string[] drinks = new string[] { "", "1.Soda", "2.Water", "3.Juice" };
        //login free account
        string adminUsername = "admin";
        string adminPassword = "admin";

        //for login creation error
        int attempt = 0;

        
        public void userLogin (){
            Console.WriteLine("Do you have an account:(Yes or No)");
            string firstans = Console.ReadLine().ToLower();
            if (firstans == "yes")
            {
                Console.WriteLine("Proceed");
                Console.WriteLine("");
                Console.Write("Enter your Username: ");
                string userName = Console.ReadLine();
                Console.Write("Enter your Password: ");
                string userPass = Console.ReadLine();
                if (userName == adminUsername && userPass == adminPassword)
                {

                    Console.WriteLine("Proceed");
                }
                else
                {
                    Console.WriteLine("Username or Password is wrong try again later");
                    return;
                }


            }
            else if (firstans == "no")
            {

                Console.Write("Create Username: ");
                string fUsername = Console.ReadLine();
                Console.Write("Create Password: ");
                string fPassword = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Proceed To Sign Up");
                Console.WriteLine("");
                Console.WriteLine("");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("Enter Username:");
                    string eUserame = Console.ReadLine();
                    Console.Write("Enter Password:");
                    string ePassword = Console.ReadLine();
                    if (eUserame == fUsername && fPassword == ePassword)
                    {
                        Console.WriteLine("Proceed");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error(Up to 3 chance only)");
                        attempt++;




                    }

                }





            }

            else
            {
                Console.WriteLine("Only Yes or No Pls try again Later");
                return;
            }
            if (attempt > 2)
            {
                Console.WriteLine("Failed to login");
                return;
            }
            else
            {

                Console.WriteLine("Login Successfully");
                Console.WriteLine("");
            }

          


        }
    }


}

    