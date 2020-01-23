using System;
using System.Collections.Generic;
using System.Text;

namespace Grocery
{
    class Jam : Item
    {
        private string flavor;
        
        public override void printInfo(string itemName)
        {
            throw new NotImplementedException();
        }

        public override int Restock(Item[] list, string itemName, int q)
        {
            throw new NotImplementedException();
        }

        public override void Sell(Item[] list, string itemName, int q)
        {
            throw new NotImplementedException();
        }
    }
}
