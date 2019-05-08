using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_04;

namespace Clase04.test
{
    class Program
    {
        //Prueba de sobrecargas en metodos y constructores
        static void Main(string[] args)
        {
            DateTime fecha = DateTime.UtcNow;
            Cosa obj = new Cosa();
            Cosa obj1 = new Cosa(18);
            Cosa obj2 = new Cosa(19, fecha);
            Cosa obj3 = new Cosa(44, fecha, "carlos");
            

            /*obj.EstablecerValor(4);
            obj.EstablecerValor("carlitos");
            obj.EstablecerValor(fecha);*/

            Console.WriteLine(obj.Mostrar());
            Console.WriteLine(Cosa.Mostrar(obj));
            Console.WriteLine(obj1.Mostrar());
            Console.WriteLine(Cosa.Mostrar(obj1));
            Console.WriteLine(obj2.Mostrar());
            Console.WriteLine(Cosa.Mostrar(obj2));
            Console.WriteLine(obj3.Mostrar());
            Console.WriteLine(Cosa.Mostrar(obj3));

            Console.ReadKey();
        }
    }
}
