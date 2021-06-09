using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial_2
{
    //Inherit the Complain Class 
    class CSForm:Complain
    {
        OpeningScreen open = new OpeningScreen();

        public void OpeningCSForm()
        {
            
    
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("                         Customer Service Form");
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("  1.View Complaint");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("  2.Edit Complaint");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("  3. View Product  ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  4.Edit Product  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n");
            Console.Write("Enter No# of Choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    ShowListComplaints();
                break;
                //Still in Progress
                case 2:
                break;
                case 3:
                    ShowAllProducts();
                break;
                case 4:
                break;
                default:
                    Console.WriteLine("Numbers 1-3 only");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Returning to Main Screen");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    open.opening();
                    break;

            }
           
        }
        public void ShowCustomerServiceOption()
        {
            Console.Write("Choices  1.(Return to Customer Service)     2.(Logout)       3.(Exit Program)");
            Console.WriteLine("Enter# of Choice");
            int answer = Convert.ToInt32(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    OpeningCSForm();
                    break;
                case 2:
                    open.opening();
                    break;
                case 3:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Numbers 1-3 only");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Returning to Main Screen");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    open.opening();
                    break;

            }

        }

    }
}
