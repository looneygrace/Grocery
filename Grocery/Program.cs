using System;
using System.Collections.Generic;

namespace Grocery
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List < Item > grocery = new List< Item > (3);
            grocery[0] = new List<Fruit>();
            grocery[1] = new List<Book>();
            PrintMenu();

            Console.WriteLine("Hello World!");
        }

        private static int PrintMenu()
        {
            int choice = 0;
            Console.WriteLine("Menu: ");
            Console.WriteLine("Add an item");
            Console.WriteLine("Restock an item");
            Console.WriteLine("Sell an Item");
            Console.WriteLine("4.Info");
            choice = Console.Read();

            if (choice >=  1 && choice <= 4)
            {
                //JAM BOOK or Fruit
                return choice; 
            }
            else { return -1; }
        }
    }
}
