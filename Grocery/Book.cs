using System;
using System.Collections.Generic;
using System.Text;

namespace Grocery

{
    class Book : Item
    {
        private string author;
        private int rating;
        

        public Book():base("NO", 0.00, -1)
        {
            rating = -1;
            author = "NO AUTHOR";
            
        }

        public Book(string n, double p, int q, string a, int r) : base(n, p, q)
        {
            rating = r;
            author = a;
        }

        public override void Sell(int q)
        {
            
            double cost = getPrice() * getQuantity();
            if (q > getQuantity())//not enough
            {
                Console.WriteLine("Not Enough of " + getName());
                Console.WriteLine("We only have " + getQuantity() + ".");
                Console.WriteLine("Selling you: " + getQuantity() + ".");
                q = getQuantity();
            }
                Restock(-1 * q);
            
            //printing receipt
            printReciept(getName(), q, cost);

        }

        public override int Restock(int q)
        {
            
            int newQuantity = q + getQuantity();
            changeQuantity(newQuantity);
            return newQuantity;
        }

        public override void printInfo()
        {
            
            Console.WriteLine("Name: " + getName());
            Console.WriteLine("\tPrice: " + getPrice());
            Console.WriteLine("\tQuantity: " + getQuantity());
            Console.WriteLine("\tAuthor: " + author);
            Console.WriteLine("\tRating: " + rating);

        }

        
    }
}
