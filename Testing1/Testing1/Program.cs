using System;

namespace Testing1
{
    class Program : Arrays
    {
        static void Main(string[] args)
        {
            Complaint complaintClass = new Complaint();
            Testing1 userLoginClass = new Testing1();
            Arrays arr = new Arrays();
            User userEditingClass = new User();

            //first questions
            Console.WriteLine("                        (*>*) WELCOME (*<*)");
            Console.WriteLine("");
            Console.WriteLine("                 1.Complaint Form     2.User Login.");
            Console.Write("Enter No: ");
            int form = Convert.ToInt32(Console.ReadLine());
            
            if (form == 1)
            {
                //Complainant Datas till the end
                complaintClass.cdata();
                Console.WriteLine("Would you like to try again? Yes or No");
                string answer2 = Console.ReadLine().ToLower();
                if(answer2== "yes")
                {
                    complaintClass.cdata();
                    return;

                }
                else
                {

                    Console.WriteLine("Thanks for Using our system");
                    return;
                }

            }
            else if (form == 2)
            {
                //user data till the end
                userLoginClass.userLogin();

            }

            userEditingClass.use();
            Console.WriteLine("Would you like to see view the product again");
            string answ = Console.ReadLine();
            if (answ == "yes")
            {
                userEditingClass.use();
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("We'll try to imporove user Features later on Thank you");
                Console.WriteLine("Finish");
                return;
            }

        }
    }

}
