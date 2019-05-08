using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase05.Entidades;

namespace Clase_04.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinta tinta1 = new Tinta();
            Tinta tinta2 = new Tinta(ConsoleColor.Cyan);
            Tinta tinta3 = new Tinta(ConsoleColor.Red, ETipoTinta.China);
            Tinta tinta4 = new Tinta();
            Pluma pluma1 = new Pluma();
            Pluma pluma2 = new Pluma("Fabricio - Castelli");
            Pluma pluma3 = new Pluma("Chicho's pencil", tinta3);
            Pluma pluma4 = new Pluma("bic", tinta2, 14);
            //Tinta tinta4 = tinta1;

            /*Console.WriteLine(Tinta.Mostrar(tinta1));
            Console.WriteLine(Tinta.Mostrar(tinta2));
            Console.WriteLine(Tinta.Mostrar(tinta3));
            Console.WriteLine(Tinta.Mostrar(tinta4));*/
            Console.WriteLine(pluma4);
            /*Console.WriteLine(Pluma.Mostrar(pluma3));
            Console.WriteLine(Pluma.Mostrar(pluma2));
            Console.WriteLine(Pluma.Mostrar(pluma1));*/

            /*if (tinta1.Equals(tinta4) == true) //Equals compara si la direccion de memoria reservada en el heap para ambos objetos es la misma (es decir, apuntan al mismo lugar)
                Console.WriteLine("Tinta 1 es igual a Tinta 4");
            else
                Console.WriteLine("Tinta 1 NO es igual a Tinta 4");*/

            /*if (tinta4 == tinta1)
                Console.WriteLine("Tinta 1 es igual a Tinta 4"); 
            else
                Console.WriteLine("Tinta 1 NO es igual a Tinta 4");*/

            if(pluma1 == tinta1)
                Console.WriteLine("Tinta 1 es igual a Tinta 4");
            else
                Console.WriteLine("Tinta 1 NO es igual a Tinta 4");

            Console.ReadKey();
        }
    }
}
