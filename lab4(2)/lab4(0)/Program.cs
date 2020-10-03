using System;

namespace lab4_0_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name");
            string d = Console.ReadLine();
            Console.WriteLine("Id");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Price");
            double c = Convert.ToDouble(Console.ReadLine());
            Guitar g = new Guitar(b,d,c);
            List list = new List();
            list.DisplayList(g);

            
        }
    }
}
