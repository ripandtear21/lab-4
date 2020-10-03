using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace lab4_0_
{
    class Name:Guitar
    {
        public Name(int i, string n, double p) : base(i, n, p)
        {
            
        }
        public override void DisplayName()
        {
            Debug.WriteLine(name);
        }
    }
}
