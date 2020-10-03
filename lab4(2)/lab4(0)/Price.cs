using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace lab4_0_
{
    class Price:Guitar
    {
        public Price(int i, string n, double p) : base(i, n, p)
        {

        }
        public override void DisplayPrice()
        {
            Debug.WriteLine(price);
        }
    }
    
}
