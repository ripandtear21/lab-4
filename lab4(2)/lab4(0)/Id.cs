using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace lab4_0_
{
    class Id:Guitar
    {
        public Id(int i, string n, double p) : base(i, n, p)
        {
            
        }
        public override void DisplayId()
        {
            Debug.WriteLine(id);
        }
    }
}
