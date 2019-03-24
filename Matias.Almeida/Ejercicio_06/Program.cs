using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06{
    class Ejercicio_06{
        static void Main(string[] args){
            long year1;
            long year2;
            short flag = 0;

            Console.Title = "Ejercicio_06";

            Console.Write("Ingrese un anio como extremo inferior del rango: ");
            year1 = int.Parse(Console.ReadLine());

            while (year1 <= 0){
                Console.Write("ERROR. Los anios no pueden ser negativos. Ingrese nuevamente: ");
                year1 = int.Parse(Console.ReadLine());
            }

            Console.Write("Ingrese un anio como extremo superior del rango: ");
            year2 = int.Parse(Console.ReadLine());

            while (year2 <= year1){
                Console.Write("ERROR. El extremo superior no puede ser menor que el extremo inferior. Ingrese nuevamente: ");
                year2 = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Los anios bisiestos comprendidos entre {0:#,###} y {1:#,###} son:", year1, year2);

            while (year1++ < year2){
                if (year1 % 400 == 0 || year1 % 4 == 0){
                    Console.WriteLine("{0:#,###}", year1);
                    flag = 1;
                }
            }

            if (flag == 0)
                Console.WriteLine("No se encontraron anios bisiestos en ese rango.");

            Console.ReadKey();
        }
    }
}
