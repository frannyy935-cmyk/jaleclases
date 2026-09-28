using System;
using System.Collections.Generic;
using System.Text;

namespace jaleclases
{
    internal class Saiyan : Humano
    {
        public int Ki;
        public System.Boolean Cola, CelulasS;
        public void Tsuper_Saiyan()
        {
            if (CelulasS == false)
            {
                Console.WriteLine(nombre + " Es incapaz de transformarse en Super Saiyan");
            }
            else
            {
                Console.WriteLine(nombre + " Se transforma en el legendario Super Saiyajin");
            }
        }
        public void Tozaru()
        {
            if (Cola == true)
            {
                Console.WriteLine(nombre + " Se transforma en un Ozaru (Es un Nahual)");
            }
            else
            {
                Console.WriteLine(nombre + " Es incapaz de transformarse en ozaru");
            }
        }
    }
}
