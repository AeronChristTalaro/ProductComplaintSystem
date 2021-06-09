using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial_2
{
    public class Complain
    {
        public List<string> food = new List<string> { "Food: ", "Lolipop    ", "Honey   ", "Meat" };
        public List<string> drinks = new List<string> { "Drinks: ", "Gatorade   ", "Royal   ", "Soda" };



        public List<string> complaintName = new List<string> { "Name: ","Nakiri" };
        public List<string> complaintAge = new List<string> { "Age: ","18" };
        public List<string> complaintEmailAddress = new List<string> { "ListEmailAddress ", "@nakirigumi"};
        public List<string> complaintNumber = new List<string> { "Number: ", "0919321312"};
        public List<string> complaintProduct = new List<string> { "Product ", "Lolipop"};
        public List<string> complaintReview = new List<string> { "Review: ", "Expired"};
        public List<string> complaintRemarks = new List<string> { "Remarks: ", "Resolved" };

        string seperator = "------------------------";

        public void showFood()
        {
            food.ForEach(Console.Write); Console.WriteLine("   ");
        }
        public void showDrinks()
        {
            drinks.ForEach(Console.Write); Console.WriteLine("   ");
        }

        public void getcName()
        {

            Console.Write("Enter Name: ");
            Console.ForegroundColor = ConsoleColor.Green;
            complaintName.Add(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            complaintRemarks.Add("Pending");   
        }
        public void getAge()
        {
            Console.Write("Enter Age: ");
            Console.ForegroundColor = ConsoleColor.Green;
            complaintAge.Add(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void geteEmailAddress()
        {
            Console.Write("Enter Email Address: ");
            Console.ForegroundColor = ConsoleColor.Green;
            complaintEmailAddress.Add(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void getNumber()
        {
            Console.Write("Enter Number: ");
            Console.ForegroundColor = ConsoleColor.Green;
            complaintNumber.Add(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void getProduct()
        {
            Console.WriteLine("List of Product available");
            Console.ForegroundColor = ConsoleColor.Yellow;
            showFood(); Console.WriteLine(seperator);
            Console.ForegroundColor = ConsoleColor.Blue;
            showDrinks(); Console.WriteLine(seperator);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nEnter ProductName: ");
            Console.ForegroundColor = ConsoleColor.Green;
            complaintProduct.Add(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void getRemarks()
        {
            Console.Write("Enter Complaint Remarks: ");
            Console.ForegroundColor = ConsoleColor.Green;
            complaintReview.Add(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void ShowAllProducts()
        {
            food.ForEach(Console.WriteLine);
            Console.WriteLine(seperator);
            drinks.ForEach(Console.WriteLine); 
        }
        public void ShowListComplaints()
        {
            for (int i = 0; i < complaintEmailAddress.Count; i++)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("                    Complaint List Data File\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(seperator);
                complaintName.ForEach(Console.WriteLine); Console.WriteLine(seperator);
                complaintAge.ForEach(Console.WriteLine); Console.WriteLine(seperator);
                complaintEmailAddress.ForEach(Console.WriteLine); Console.WriteLine(seperator);
                complaintNumber.ForEach(Console.WriteLine); Console.WriteLine(seperator);
                complaintProduct.ForEach(Console.WriteLine); Console.WriteLine(seperator);
                complaintReview.ForEach(Console.WriteLine); Console.WriteLine(seperator);
                complaintRemarks.ForEach(Console.WriteLine); Console.WriteLine(seperator);

            }
            }



            public void addListValue() {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("                    Complainants Detail");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n");
            getcName();
            getAge();
            geteEmailAddress();
            getNumber();
            Console.WriteLine("Proceeding to Complaint Form");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            AnswerComplaintForm();
        }
        public void AnswerComplaintForm()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("                    Complainants Form");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            getProduct();
            getRemarks();
            Console.Clear();
            Console.WriteLine("Do you want to add another Complaints?");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Choices:1.(Yes)");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" 2.(No)");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(" 3.(View all Complains)");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("4.(Back to Opening Screen)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n");
            Console.Write("Enter number Choice:");
            int answer = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (answer)
            {
                case 1:
                    addListValue();
                    break;
                case 2:
                    SendingFeedback();
                    break;
                case 3:
                    showListValue();
                    break;
                case 4:
                    OpeningScreen open = new OpeningScreen();
                    open.opening();
                    break;
                default:
                    Console.WriteLine("Error Going back to Main Menu");
                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                    OpeningScreen open2 = new OpeningScreen();
                    open2.opening();
                    break;
            }

        }

        public void showListValue()
        {
            for (int i = 0; i <complaintEmailAddress.Count; i++)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("             Complaint List Data File\n");
                Console.ForegroundColor = ConsoleColor.White ;

                complaintName.ForEach(Console.WriteLine); Console.WriteLine(seperator);
                complaintAge.ForEach(Console.WriteLine); Console.WriteLine(seperator);
                complaintEmailAddress.ForEach(Console.WriteLine); Console.WriteLine(seperator);
                complaintNumber.ForEach(Console.WriteLine); Console.WriteLine(seperator);
                complaintProduct.ForEach(Console.WriteLine); Console.WriteLine(seperator);
                complaintReview.ForEach(Console.WriteLine); Console.WriteLine(seperator);
                complaintRemarks.ForEach(Console.WriteLine); Console.WriteLine(seperator);

                Console.WriteLine("\nPress Enter to End the System");
                Console.ReadKey();
                Console.Clear();
                SendingFeedback();

            }      

        }
        public void SendingFeedback()
        {

            Console.WriteLine("Thanks for Using our System");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("We'll seed a feedback as soon as possible");
            System.Threading.Thread.Sleep(3000);
            System.Environment.Exit(0);
        }

    }
}
