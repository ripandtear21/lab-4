using System;
using System.Collections.Generic;
using System.Text;

namespace lab4_2_
{
    class ElectricGuitars:List
    {
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
