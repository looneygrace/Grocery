using System;
using System.Collections.Generic;
using System.Text;

namespace Grocery
{
    class Fruit : Item
    {


        private int condition; //Condition(1-> Rotten, 5-> not ripe
        private string origin;

        List<Fruit> fruits;
        public Fruit(string n, double p, int q, string o, int c) : base(n,p,q) {
            
            condition = c;
            origin = o;
        }
        public override void Sell(int q)
        {
            double cost = getPrice() * getQuantity();
            if (q > getQuantity())
            {
                Console.WriteLine("Not Enough of " + getName());
                Console.WriteLine("We only have " + getQuantity() + ".");
                Console.WriteLine("Selling you: " + getQuantity() + ".");
                Restock(q);
            }
            else
            {
                Restock(-1 * q);
            }

            //printing receipt
            printReciept(getName(), q, cost);
        }

        public override int Restock(int q)
        {
            int newQuantity = q + getQuantity();
            changeQuantity(newQuantity);
            //might want to check if quantity is too big or too small(not enough in stock)
            return newQuantity;
        }

        public override void printInfo()
        {
            Console.WriteLine("Name: " + getName());
            Console.WriteLine("Price: " + getPrice());
            Console.WriteLine("Quantity: " + getQuantity());
            Console.WriteLine("Condition: " + condition);
            Console.WriteLine("Origin: " + origin);
        }

        public void updateConditon(int c)
        {
            //might need more
            condition = c;
        }
    }
}
