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

        public abstract void Sell(Item[] list, string itemName, int q);
        public abstract int Restock(Item[] list, string itemName, int q);
        public abstract void printInfo(string itemName);
        public int findItem(Item[] list, string name)
        {
            int index = 0;
            bool found = false;
            while(list[index].Name != name)
            {
                index++;
                if (list[index].Name == name)
                {
                    found = true;
                }
            }
            if(found == true)
            {
                return index;
            }
            else
            {
                return -1;
            }
        }

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

        public static implicit operator Item(List<Fruit> v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Item(List<Book> v)
        {
            throw new NotImplementedException();
        }
    }

}
