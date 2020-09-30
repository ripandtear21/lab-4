using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace lab4_4_
{
     class ApplicationLicense
    {
        private string lic;
        public static bool trial;
        public static bool pro;
        public static bool common;






        public ApplicationLicense(string l)
        {
            lic = l;
        }
        public ApplicationLicense()
        {

        }

         public void AllowTrial()
        {
                
            
            // C2T14 - SGC6C - 4A6Y8 Pro version
            //MBLQ6 - 7E3MO - 29R2P - Trial version
            if ( lic == "null")
            {
                AllowCommon();
                common = true;
            }
            else if(lic == "C2T14 - SGC6C - 4A6Y8")
            {
                AllowPro();
                pro = true;
            }
            else if(lic == "MBLQ6 - 7E3MO - 29R2P")
            {
                Console.Clear();
                Console.WriteLine("Спасибо, что пользуетесь нашей продукцией.Вы активировали пробную версию программы.");
                
                trial = true;
            }
            
            
        }
        public void AllowCommon()
        {
            Console.Clear();
            Console.WriteLine("Спасибо, что пользуетесь нашей продукцией.Вы активировали бесплатную версию программы.");
             
        }
        public void AllowPro()
        {
            Console.Clear();
            Console.WriteLine("Спасибо, что пользуетесь нашей продукцией.Вы активировали профессиональную версию программы.");
             
        }
    }
}
