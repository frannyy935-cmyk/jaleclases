using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primera
{
    internal class Vampiro: Humano
    {
        public int colmillos;

        public void Transformarse()
        {
            Console.WriteLine(nombre + " Está cambiando su forma");
        }

        public void Paralizar()
        {
            Console.WriteLine(nombre + " Está paralizando al enemigo");
        }

        public override void Comer()
        {
            Console.WriteLine(nombre + " Está succionando la sangre");
        }

        public override void Ver()
        {
            base.Ver();
            Console.WriteLine(nombre + " Está viendo en la oscuridad");
        }

    }
}
