using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto01
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.Write("Ingrese un nombre: ");
            name = Console.ReadLine();
            // Console.ReadLine()-
            //                   |
            //                   ^
            Console.WriteLine(name); // puedo obviar el uso de la variable y usar directamente el metodo.
            Console.ReadKey();
        }
    }
}
