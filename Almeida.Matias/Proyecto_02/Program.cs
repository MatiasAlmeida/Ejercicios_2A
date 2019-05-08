using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje = "\nhola";

            Sello.color = ConsoleColor.Cyan;

            Sello.ImprimirEnColor();
                
            Console.WriteLine(Sello.Imprimir());

            Sello.Borrar();

            Sello.mensaje = "Otro color pa";

            Sello.color = ConsoleColor.White;

            Sello.ImprimirEnColor();

            Console.WriteLine(Sello.Imprimir());

            Sello.Borrar();

            Console.ReadKey();


        }
    }
}
