using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primera
{
    internal class Cemtauro : Humano
    {
        public int patas, pezunas;
        public bool cola;

        public void Galopar()
        {
            if (patas > 3)
            {
                Console.WriteLine(nombre + " Está galopando");
            }
            else
            {
                Console.WriteLine(nombre + " no puede galopar");
            }


        }

        public override void Caminar()
        {
            if (patas > 3)
            {
                Console.WriteLine(nombre + " Está caminando");
            }
            else
            {
                Console.WriteLine(nombre + " no puede caminar");
            }
        }

        public override void Dormir()
        {
            if(patas > 3)
            {
                Console.WriteLine(nombre + " Está duermiendo sobre sus patas");
            }
            else
            {
                Console.WriteLine(nombre + " Está tumbado en el suelo");
            }
        }

    }
}
