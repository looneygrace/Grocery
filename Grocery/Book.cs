using System;
using System.Collections.Generic;
using System.Text;

namespace Grocery
{
    class Book : Item
    {
        private string author;
        private int rating;
        public Book(string n, double p, int q, string a, int r) : base(n, p, q)
        {
            rating = r;
            author = a;
        }

        public override void Sell(Item[] list, string itemName, int q)
        {
            int itemIndex = findItem(list, itemName);
            double cost = getPrice() * getQuantity();
            Restock(list, itemName, -1 * q);
            //printing receipt
            printReciept(getName(), q, cost);

        }
        public override int Restock(Item[] list, string itemName, int q)
        {
            int index = findItem(list, itemName);
            int newQuantity = q + list[index].getQuantity();
            list[index].changeQuantity(newQuantity);
            //might want to check if quantity is too big or too small(not enough in stock)
            return newQuantity;
        }
        public override void printInfo(string itemName)
        {
            throw new NotImplementedException();
        }
    }
}
