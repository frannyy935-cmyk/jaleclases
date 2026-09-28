using System;
using System.Collections.Generic;
using System.Text;

namespace jaleclases
{
    internal class Neko : Humano
    {
        public System.Boolean cola;
        public string orejas;


        public void MoverCola()
        {
            if (cola == true)
            {
                Console.WriteLine(nombre + " Menea su cola");
            }
            else
            {
                Console.WriteLine(nombre + " No tiene cola para menear");
            }
        }
    }
}
