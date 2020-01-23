using System;
using System.Collections.Generic;
using System.Text;

namespace Grocery
{
    class Jam : Item
    {
        
        
        private string type;
        
        public Jam() : base("NO", 0.00, -1)
        {
            type = "NO" ;
        }
        public Jam(string n, double p, int q, string t) : base(n, p, q)
        {
            type = t;
        }

        public override void printInfo()
        {
            Console.WriteLine("Name: " + getName());
            Console.WriteLine("Price: " + getPrice());
            Console.WriteLine("Quantity: " + getQuantity());
            Console.WriteLine("Type: " + type);
        }

        public override int Restock(int q)
        {
            int newQuantity = q + getQuantity();
            changeQuantity(newQuantity);
            return newQuantity;
        }

        public override void Sell( int q)
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
    }

}
