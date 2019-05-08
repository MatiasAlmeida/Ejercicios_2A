using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;

            Console.Title = "Ejercicio_02";

            Console.Write("Ingrese un numero entero: ");
            num1 = int.Parse(Console.ReadLine());

            while (num1 <= 0)
            {
                Console.Write("ERROR. Ingrese un numero entero positivo: ");
                num1 = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("{0:#,###}^2 = {1:#,###}", num1, Math.Pow(num1, 2));
            Console.WriteLine("{0:#,###}^3 = {1:#,###}", num1, Math.Pow(num1, 3));
            Console.ReadKey();
        }
    }
}
