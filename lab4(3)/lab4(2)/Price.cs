using System;
using System.Collections.Generic;
using System.Text;

namespace lab4_2_
{
    class Priced:List
    {
        public double P
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
    }
}
