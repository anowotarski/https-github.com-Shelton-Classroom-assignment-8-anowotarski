using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace CakeOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Orders> orders = new List<Orders>();

            WriteLine("Welcome to Tony's Coven of Cakes!";
            WriteLine("For our application, we will display the menu of designs and decorations");
            WriteLine("You can only pick one of each when ordering in this application.");

            char moreItems = 'y';
            int counter = 0;

            while(moreItems == 'y')
            {
                WriteLine("Let's get the items for item {0}", counter +1);

                collectOrder(ref orders);
                counter++;
                WriteLine("Would you like to continue? Y/N? ");
                moreItems = Convert.ToChar(ReadLine());

            }//ends while loop

            ReadKey();

        }//ends main

        public static void collectOrder(ref List<Orders> o)
        {
            var listOfDesigns = File.ReadLines("Designs.csv").Select(line => new Designs(line)).ToList();
            var listOfDecorations = File.ReadLines("Decorations.csv").Select(line => new Decorations(line)).ToList();

            WriteLine("Name for this Order Item");
            string name = ReadLine();

            WriteLine("Which design would like like? ");
            foreach(Designs d in listOfDesigns)
            {
                WriteLine($"{d.DesignID}\t{d.DesignName}");
            }

            int a = Convert.ToInt32(ReadLine());
            string design = listofDesigns[a - 1].DesignName;

        }
    }
}
