using System;

namespace lab4_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Model model = new Model("Gibson", 2500, 23124453);
            Guitar guitar = model;
            guitar.GetName();

            
        }
    }
}
