using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial_2
{
    class MainClass
        //This class calls the opening screen which holds all the 
    {
        static void Main(string[] args)
        {



            Console.WindowHeight = 30;
            Console.WindowWidth = 72;


            Console.Title = "Product Complaint System";
            OpeningScreen open = new OpeningScreen();
            open.opening();
        }
    }
}
