
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial_2
{

    //Calls all the different classes
    class OpeningScreen
    {
        public void opening()
        {
            Accounts acc = new Accounts();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"                        (*>*)/ WELCOME !(*<*)!");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("           1.Complaint Form");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  2.Login Account  ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Still in Progress Have errors in using list as a conditional
            Console.WriteLine("  3.Create Login  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter No: ");
            int answer = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (answer)
            {
                case 1:
                    Complain call = new Complain();
                    call.addListValue();
                    break;
                case 2:

                    acc.UseCreateAcccount();
                    break;

                //In progress Still Fixing errors
                //case 3:
                //    acc.CreateAccount();
                //    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid Value");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("System Restarting");
                    for (int i = 5; i > 0; i--)
                    {
                        Console.Write(i + ", ");
                        System.Threading.Thread.Sleep(500);

                    }
                    Console.Clear();
                    OpeningScreen open = new OpeningScreen();
                    open.opening();
                    break;
            }
        }
    }
}
