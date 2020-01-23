using System;
using System.Collections.Generic;
using System.Text;

namespace Grocery
{
    abstract class Item : Program
    {
        private string name { get; set; }
        private double price { get; set; }
        private int quantity { get; set; }

        //constructor
        public Item(string n, double p, int q)
        {
            name = n;
            price = p;
            quantity = q;
        }

        public abstract void Sell(string itemName, int q);
        public abstract int Restock(string itemName, int q);
        public abstract void printInfo(string itemName);
        

        public void printReciept(string name, int amount, double cost)
        {
            Console.WriteLine("You purchased " + amount + "of " + name + " for " + cost);
        }

        public int changeQuantity(int newQuantity)
        {
            quantity = newQuantity;
            return quantity;
        }

        public double getPrice()
        {
            return price;
        }
        public int getQuantity()
        {
            return quantity;
        }
        public string getName()
        {
            return name;
        }

    }

}
