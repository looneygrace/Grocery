using System;
using System.Collections.Generic;

namespace Grocery
{
    class Program
    {
        
        static void Main(string[] args)
        {
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

        private static void runFruit(List<Fruit> f, int choice)
        {
            string name, origin;
            int quantity, rating;
            double price;
            if (choice == 1)
            {

                Console.WriteLine("Fruit Name: ");
                name = Console.ReadLine();

                Console.WriteLine("Fruit Origin (where is it from?) : ");
                origin = Console.ReadLine();

                Console.WriteLine("Fruit Quantity: ");
                quantity = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Fruit Price: ");
                price = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Fruit Condition (1(Rotten) - 5(not ripe): ");
                rating = Convert.ToInt32(Console.ReadLine());
                Fruit temp = new Fruit(name, price, quantity, origin, rating);
                f.Add(temp);


            }
            else if (choice == 2)
            {
                //restock
                Console.WriteLine("Item to restock? ");
                name = Console.ReadLine();
                int index = findFruit(f, name);
                if (index == -1)
                {
                    Console.WriteLine("Item NOT FOUND");
                }
                else
                {
                    Console.WriteLine("Prior Restock: ");
                    f[index].printInfo();
                    Console.WriteLine("Quantity? ");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    f[index].Restock(quantity);
                    Console.WriteLine("After Restock: ");
                    f[index].printInfo();

                }
            }

            else if (choice == 3)
            {
                //sell
                Console.WriteLine("Item to sell? ");
                name = Console.ReadLine();
                int index = findFruit(f, name);
                if (index == -1)
                {
                    Console.WriteLine("Item NOT FOUND");
                }
                else
                {
                    Console.WriteLine("Prior sale: ");
                    f[index].printInfo();
                    Console.WriteLine("Quantity? ");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    f[index].Sell(quantity);
                    Console.WriteLine("After sale: ");
                    f[index].printInfo();
                }
            }

            else if (choice == 4)
            {
                //print info
                Console.WriteLine("Item name? ");
                name = Console.ReadLine();
                int index = findFruit(f, name);

                if (index == -1)
                {
                    Console.WriteLine("Item NOT FOUND");
                }
                else
                {
                    f[index].printInfo();
                }
            }
        }

        public static int findFruit(List<Fruit> fruits, string name)
        {
            int index = 0;
            bool found = false;
            while (fruits[index].getName() != name)
            {
                index++;
                if (fruits[index].getName() == name)
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

        private static void runJam(List<Jam> j, int choice)
        {
            string name, type;
            int quantity;
            double price;
            if (choice == 1)
            {

                Console.WriteLine("Jam Name: ");
                name = Console.ReadLine();

                Console.WriteLine("Jam type (Jelly, Marmalade, Perserves?): ");
                type = Console.ReadLine();

                Console.WriteLine("Jam Quantity: ");
                quantity = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Jam Price: ");
                price = Convert.ToDouble(Console.ReadLine());

                
                Jam temp = new Jam(name, price, quantity, type);
                j.Add(temp);


            }
            else if (choice == 2)
            {
                //restock
                Console.WriteLine("Item to restock? ");
                name = Console.ReadLine();
                int index = findJams(j, name);
                if (index == -1)
                {
                    Console.WriteLine("Item NOT FOUND");
                }
                else
                {
                    Console.WriteLine("Prior Restock: ");
                    j[index].printInfo();
                    Console.WriteLine("Quantity? ");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    j[index].Restock(quantity);
                    Console.WriteLine("After Restock: ");
                    j[index].printInfo();

                }
            }

            else if (choice == 3)
            {
                //sell
                Console.WriteLine("Item to sell? ");
                name = Console.ReadLine();
                int index = findJams(j, name);
                if (index == -1)
                {
                    Console.WriteLine("Item NOT FOUND");
                }
                else
                {
                    Console.WriteLine("Prior sale: ");
                    j[index].printInfo();
                    Console.WriteLine("Quantity? ");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    j[index].Sell(quantity);
                    Console.WriteLine("After sale: ");
                    j[index].printInfo();
                }
            }

            else if (choice == 4)
            {
                //print info
                Console.WriteLine("Item name? ");
                name = Console.ReadLine();
                int index = findJams(j, name);

                if (index == -1)
                {
                    Console.WriteLine("Item NOT FOUND");
                }
                else
                {
                    j[index].printInfo();
                }
            }
        }
        public static int findJams(List<Jam> jams, string name)
        {
            int index = 0;
            bool found = false;
            while (jams[index].getName() != name)
            {
                index++;
                if (jams[index].getName() == name)
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
