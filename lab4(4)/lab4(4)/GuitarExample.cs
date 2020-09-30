using System;
using System.Collections.Generic;
using System.Text;

namespace lab4_4_
{
    class GuitarExample:ApplicationLicense
    {
        private string name;
        private double price;
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
        public double Price
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
        public GuitarExample(string name,double price) : base() 
        {
            Name = name;
            Price = price;
        }
        public void Example()
        {
            
            
            if (trial == 1)
            {
                Console.WriteLine($"Название гитары:{name}\nЦена гитары:{price}");
            }
            if (pro == 1)
            {
                Console.WriteLine($"Название Гитары:{name}\nЦена гитары:{price}");
            }
            if (common == 1)
            {
                Console.WriteLine("Вы пользуетесь ознакомительной версией программы, пожалуйста активируйте лицензию!");
                
            }
            
            

        }

    }
}
