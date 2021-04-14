using System;
using System.Linq;
namespace ProductComplaintManagementSystem
{
    class Program
    {

        
        static void Main(string[] args)
            
        {
            string[] acName = new string[] { };
            string[] Secondproducts = new string[] { };

            string[,] product = { { "Raw Meat", "Raw Chicken","Raw Beef" } };


            string useMain = "admin";
            string pasMain = "admin";

            Console.WriteLine("Do you have an Acount Already?");
            string accAnswer = Console.ReadLine().ToLower();
            if (accAnswer == "no")
            {
                Console.WriteLine("Create Username");
                string createName = Console.ReadLine();
                Console.WriteLine("Create Password");
                string createPass = Console.ReadLine();
            }
            else if(accAnswer =="yes"){

                    Console.WriteLine("Proceed");
                }

            else
            {   
                Console.WriteLine("Only Yes or No answer");
                return;
            }
            Console.Write("Please Enter your Username: ");
            string useName = Console.ReadLine();
            Console.Write("Please Enter your Password: ");
            string pasName = Console.ReadLine();

           
            if(useName=="" && pasName == ""||useMain== useMain &&pasMain== pasMain)
            {

                Console.WriteLine("Proceed");
            }

            else
            {

                Console.WriteLine("Invalid Username or Password");
                return;
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("            ********************");
            Console.WriteLine("Welcome to Product Complaint Management System!");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("");
            Console.WriteLine("Press '1' To view the Product    Press'2' View List of Complaints      Press'3' tO Add Complaints" );
            Console.WriteLine("");
            Console.Write("Choose from the list: ");
            int wants = Convert.ToInt32(Console.ReadLine());
            if (wants == 1)
            {

               for(int i=0; i>5; i++)
                {
                   // Console.WriteLine(product[i]);
                }

            }



                    }
    }
}
