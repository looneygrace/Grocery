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
        public override void Sell(string itemName, int q)
        {
            int index = findItem(itemName);
            double cost = fruits[index].getPrice() * fruits[index].getQuantity();
            if (q > fruits[index].getQuantity())
            {
                Console.WriteLine("Not Enough of " + fruits[index].getName());
                Console.WriteLine("We only have " + fruits[index].getQuantity() + ".");
                Console.WriteLine("Selling you: " + fruits[index].getQuantity() + ".");
                Restock(itemName, q);
            }
            else
            {
                Restock(itemName, -1 * q);
            }

            //printing receipt
            printReciept(getName(), q, cost);
        }

        public override int Restock(string itemName, int q)
        {
            int index = findItem(itemName);
            int newQuantity = q + fruits[index].getQuantity();
            fruits[index].changeQuantity(newQuantity);
            //might want to check if quantity is too big or too small(not enough in stock)
            return newQuantity;
        }

        public override void printInfo(string itemName)
        {
            int index = findItem(itemName);
            Console.WriteLine("Name: " + fruits[index].getName());
            Console.WriteLine("Price: " + fruits[index].getPrice());
            Console.WriteLine("Quantity: " + fruits[index].getQuantity());
            Console.WriteLine("Expiration Date: " + fruits[index].expDate);
            Console.WriteLine("Origin: " + fruits[index].origin);
        }

        public void updateConditon(string itemName)
        {

        }
        public int findItem(string name)
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
    }
}
