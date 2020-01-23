using System;
using System.Collections.Generic;

namespace Grocery
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Fruit f;
            Book b; 

            int choice = PrintMenu();
            int itemClass = 0;
            Console.WriteLine("with what class: ");
            Console.WriteLine("1. BOOK");
            Console.WriteLine("2. Fruit");
            Console.WriteLine("3. Jam");
            Console.WriteLine("any other character to exit");
            if (itemClass == 1)
            {
                runBook(b, choice);
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
            string name, author;
            int quantity, rating;
            double price;
            if (choice == 1)
            {

                Console.WriteLine("Book Name: ");
                name = Console.ReadLine();

                Console.WriteLine("Book Author: ");
                author = Console.ReadLine();

                Console.WriteLine("Book Quantity: ");
                quantity = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Book Price: ");
                price = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Book Rating: ");
                rating = Convert.ToInt32(Console.ReadLine());
                Book temp = new Book(name, price, quantity, author, rating);
                b.Add(temp);


            }
            else if (choice == 2)
            {
                //restock
                Console.WriteLine("Item to restock? ");
                name = Console.ReadLine();
                int index = findBook(b, name);
                if (index == -1)
                {
                    Console.WriteLine("Item NOT FOUND");
                }
                else
                {
                    Console.WriteLine("Prior Restock: ");
                    b[index].printInfo();
                    Console.WriteLine("Quantity? ");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    b[index].Restock(quantity);
                    Console.WriteLine("After Restock: ");
                    b[index].printInfo();

                }
            }

            else if (choice == 3)
            {
                //sell
                Console.WriteLine("Item to sell? ");
                name = Console.ReadLine();
                int index = findBook(b, name);
                if (index == -1)
                {
                    Console.WriteLine("Item NOT FOUND");
                }
                else
                {
                    Console.WriteLine("Prior sale: ");
                    b[index].printInfo();
                    Console.WriteLine("Quantity? ");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    b[index].Sell(quantity);
                    Console.WriteLine("After sale: ");
                    b[index].printInfo();
                }
            }

            else if (choice == 4)
            {
                //print info
                Console.WriteLine("Item name? ");
                name = Console.ReadLine();
                int index = findBook(b, name);
                
                if (index == -1)
                    {
                        Console.WriteLine("Item NOT FOUND");
                    }
                    else
                    {
                        b[index].printInfo();
                    }
            }
        }
        public static int findBook(List<Book> books, string name)
        {
            int index = 0;
            bool found = false;
            while (books[index].getName() != name)
            {
                index++;
                if (books[index].getName() == name)
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

        private static void runFruit(Fruit f, int choice)
        {
            if (choice == 1)
            {
                Console.ReadLine();
            }
            else if (choice == 2)
            {
                //restock
                Grocery.Book<hey>
            }
            else if (choice == 3)
            {
                //sell
            }
            else if (choice == 4)
            {
                //print info
            }
        }
    }
}
