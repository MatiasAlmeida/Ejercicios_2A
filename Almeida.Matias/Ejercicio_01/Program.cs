using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria;

namespace Ejercicio_01{
    class Program{
        static void Main(string[] args){
            int num = 0;
            short cont = 0;
            int max = 0;
            int min = 0;
            //float prom = 0;
            float acum = 0;

            Console.Title = "Ejercicio_01";

            while (cont++ < 5)
            {
                Console.Write("Ingrese un numero: ");

                num = int.Parse(Console.ReadLine());
                acum += num;

                if (cont == 0 || num > max)
                {
                    max = num;
                }
                else
                {
                    min = num;
                }
            }

            //Console.WriteLine("{0}{1}", "Promedio: ", prom);
            //Console.WriteLine("{0}{1}", "Maximo: ", aux1);
            //Console.WriteLine("{0}{1}", "Minimo: ", aux2);
            Console.WriteLine("Maximo: {0:#,###.00}", max);
            Console.WriteLine("Minimo: {0:#,###.00}", min);
            Console.WriteLine("Promedio: {0:#,###.00}", acum / cont);
            Console.WriteLine(Prueba.saludar());
            Console.ReadKey();
        }
    }
}
