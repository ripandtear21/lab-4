using System;
using System.Collections.Generic;
using System.Text;

namespace lab4_4_
{
    class Samples:ApplicationLicense
    {
        public Samples() : base() { }
        public void Samp()
        {
            if (pro == true)
            {
                Console.WriteLine("Выберите сэмпл звука для прослушивания:1-Clean,2-Distortion");
                int caseSwitch = Int32.Parse(Console.ReadLine());
                switch (caseSwitch)
                {
                    case 1:
                        Console.WriteLine("Прослушивание сэмпла с эффектом Clean..."); //надо реализовать сэмплы
                        break;
                    case 2:
                        Console.WriteLine("Прослушивание сэмпла с эффектом Distorion..."); //надо реализовать сэмплы
                        break;
                }
            }
            else if (common == true)
            {
                Console.WriteLine("Вы не можете пользоваться функцией сэмплов, поскольку у вас ознакомительная версия! ");
            }
           else if (trial == true)
            {
                Console.WriteLine("Вы пользуетесь  пробной версией программы, для доступа к образцам звука активируйте версию PRO.");
            }
        }

    }
}
