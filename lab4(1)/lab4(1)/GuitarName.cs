using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace lab4_1_
{
    class Guitar
    {
        public string GuitarName { get; set; }
        public int Price { get; set; }
        public Guitar (string gname,int p)
        {
            
            GuitarName = gname;
            Price = p;
        }
       public void GetName()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(GuitarName);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Price);
            Console.ResetColor();
        }
    }
    
    

}
