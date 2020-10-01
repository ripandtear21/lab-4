using System;
using System.Diagnostics;

namespace lab4_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ElectricGuitars eg = new ElectricGuitars();
            Priced price = new Priced();
            eg.Name = "Fender";
            eg.Id = 1500;
            price.P = 1345.23;

            
            Debug.WriteLine(eg.Name+"\n"+"Id:"+eg.Id+ "\n" + "Price:" + price.P);

            AcousticGuitars ag = new AcousticGuitars();
            ag.Name = "Yamaha";
            ag.Id = 2341;
            price.P = 2135.23;

            Debug.WriteLine(ag.Name + "\n" + "Id:" + ag.Id + "\n" + "Price:" + price.P);

            
          
        }
    }
}
