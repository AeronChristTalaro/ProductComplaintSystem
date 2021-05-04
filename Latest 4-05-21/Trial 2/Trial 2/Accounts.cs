using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial_2
{
    class Accounts

    {
        string user = "admin";
        string pasw = "admin";
        CustomerService custom = new CustomerService();


        OpeningScreen open2 = new OpeningScreen();
        public void ShowTitleForm()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("                           Account Form");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
        }



       
        public void UseCreateAcccount()
        {
            ShowTitleForm();
            Console.Write("Enter Username:");
            string use = Console.ReadLine();
            Console.Write("Enter Password:");
            string pas = Console.ReadLine();

            Console.Clear();

            if (use.Equals(user)&&pas.Equals(pasw))
                {

                for (int i = 3; i > 0; i--)
                {
                    Console.WriteLine("Proceeding to Customer Service Access");
                    Console.WriteLine($"{i}, ");
                    System.Threading.Thread.Sleep(500);
                    
                }
                Console.Clear();
                custom.CallingCsDatas();
            }
            else
            {
                Console.WriteLine("Wrong Admin Account");
                Console.WriteLine("Returning to Main Screen");
                for (int i = 3; i < 0; i--)
                {
                    Console.WriteLine($"{i}, ");
                    System.Threading.Thread.Sleep(500);

                }
                open2.opening();
            }

        }



    }
}
