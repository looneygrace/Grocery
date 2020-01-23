using System;
using System.Collections.Generic;
using System.Text;

namespace Grocery

{
    class Book : Item
    {
        private string author;
        private int rating;
        List<Book> books;

        public Book():base("NO", 0.00, -1)
        {
            rating = -1;
            author = "NO AUTHOR";
            books.Add(this);
        }

        public Book(string n, double p, int q, string a, int r) : base(n, p, q)
        {
            rating = r;
            author = a;
            books.Add(this);
        }

        public override void Sell(string itemName, int q)
        {
            int index = findItem(itemName);
            double cost = books[index].getPrice() * books[index].getQuantity();
            if (q > books[index].getQuantity())//not enough
            {
                Console.WriteLine("Not Enough of " + books[index].getName());
                Console.WriteLine("We only have " + books[index].getQuantity() + ".");
                Console.WriteLine("Selling you: " + books[index].getQuantity() + ".");
                q = books[index].getQuantity();
            }
                Restock(itemName, -1 * q);
            
            //printing receipt
            printReciept(getName(), q, cost);

        }

        public override int Restock(string itemName, int q)
        {
            int index = findItem(itemName);
            int newQuantity = q + books[index].getQuantity();
            books[index].changeQuantity(newQuantity);
            return newQuantity;
        }

        public override void printInfo(string itemName)
        {
            int index = findItem(itemName);
            Console.WriteLine("Name: " + books[index].getName());
            Console.WriteLine("\tPrice: " + books[index].getPrice());
            Console.WriteLine("\tQuantity: " + books[index].getQuantity());
            Console.WriteLine("\tAuthor: " + books[index].author);
            Console.WriteLine("\tRating: " + books[index].rating);

        }

        public int findItem(string name)
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
    }
}
