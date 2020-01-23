using System;
using System.Collections.Generic;

namespace Grocery
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List < Item > grocery = new List< Item > ();
            List<Item
            List<Fruit> fruits = new List<Fruit>();
            List<Book> books = new List<Book>();
            List<Jam> jams = new List<Jam>();

            int choice = PrintMenu();
            int itemClass = 0;
            Console.WriteLine("with what class: ");
            Console.WriteLine("1. BOOK");
            Console.WriteLine("2. Fruit");
            Console.WriteLine("3. Jam");
            Console.WriteLine("any other character to exit");
            if (itemClass == 1)
            {
                runBook(books, choice);
            }
            else if (itemClass == 2)
            {
                runFruit(fruits, choice);
            }
            else if (itemClass == 3)
            {
                runJam(jams, choice);
            }
            Console.WriteLine("Hello World!");
        }

        private static int PrintMenu()
        {
            int choice = 0;
            Console.WriteLine("Menu: ");
            Console.WriteLine("1. Add an item");
            Console.WriteLine("2. Restock an item");
            Console.WriteLine("3. Sell an Item");
            Console.WriteLine("4. Info");
            choice = Console.Read();

            if (choice >=  1 && choice <= 4)
            {
                return choice; 
            }
            else { return -1; }
        }
        private static void runBook(List<Book> b, int choice)
        {
            if(choice == 1)
            {
                b.
            }
            else if(choice == 2)
            {
                //restock
                Grocery.Book<hey> 
            }
                
        }
        public int findItem(type[] list, string name)
        {
            int index = 0;
            bool found = false;
            while (list[index].name != name)
            {
                index++;
                if (list[index].name == name)
                {
                    found = true;
                }
            }
            if (found == true)
            {
                return index;
            }
            else
            {
                return -1;
            }
        }
    }
}
