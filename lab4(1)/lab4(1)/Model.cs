using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace lab4_1_
{
    class Model:Guitar
    {
       public int Id { get; set; }
        public Model(string gname, int p,int id) : base(gname,p)
        {
            Id = id;
        }
        
    }
}
