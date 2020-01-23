using System;
using System.Collections.Generic;
using System.Text;

namespace Grocery
{
    class Fruit : Item
    {

        
        private int expDate; //MMDDYYYY
        private string origin;
        public Fruit(string n, double p, int q, string o, int eD) : base(n,p,q) {
            
            expDate = eD;
            origin = o;
        }
        public override void Sell(Item[] list, string itemName, int q)
        {
            throw new NotImplementedException();
        }

        public override void Restock(Item[] list, string itemName, int q)
        {
            throw new NotImplementedException();
        }

        public override void printInfo(string itemName)
        {
            throw new NotImplementedException();
        }
    }
}
