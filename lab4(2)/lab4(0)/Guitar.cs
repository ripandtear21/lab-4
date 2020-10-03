using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace lab4_0_
{
    class Guitar
    {
        public  int id;
        public  string name;
        public  double price;
        public Guitar(int i, string n, double p)
        {
            id = i;
            name = n;
            price = p;
        }
        public virtual void DisplayId()
        {
            Debug.WriteLine(id);
        }
        public virtual void DisplayName()
        {
            Debug.WriteLine(name);
        }
        public virtual void DisplayPrice()
        {
            Debug.WriteLine(price);
        }


    }
}
