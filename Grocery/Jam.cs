using System;
using System.Collections.Generic;
using System.Text;

namespace Grocery
{
    class Jam : Item
    {
        List<Jam> jams;
        
        private string type;
        
        public Jam() : base("NO", 0.00, -1)
        {
            type = "NO" ;
            jams.Add(this);
        }
        public Jam(string n, double p, int q, string t) : base(n, p, q)
        {
            type = t;
            jams.Add(this);
        }
        public override void printInfo(string itemName)
        {
            int index = findItem(itemName);
            Console.WriteLine("Name: " + jams[index].getName());
            Console.WriteLine("Price: " + jams[index].getPrice());
            Console.WriteLine("Quantity: " + jams[index].getQuantity());

        }

        public override int Restock(string itemName, int q)
        {
            throw new NotImplementedException();
        }

        public override void Sell(string itemName, int q)
        {
            throw new NotImplementedException();
        }
        public int findItem(string name)
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
