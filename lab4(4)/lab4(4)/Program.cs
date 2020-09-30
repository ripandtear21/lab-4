using System;

namespace lab4_4_
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            
            Console.WriteLine("Пожалуйста, введите код активации продукта" + "\nЕсли ключа у вас не имеется, введите в консоль null");
            string g = Console.ReadLine();
            ApplicationLicense license = new ApplicationLicense(g);
            license.AllowTrial();
            Console.WriteLine("Введите название гитары:");
            string i = Console.ReadLine();
            Console.WriteLine("Введите цену гитары:");
            double f = Convert.ToDouble(Console.ReadLine());
            GuitarExample guitar = new GuitarExample(i,f);
            guitar.Example();
            Samples sample = new Samples();
            sample.Samp();
            
            
        }
    }
}
