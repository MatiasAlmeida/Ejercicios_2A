using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03{
    class Ejercicio_03{
        static void Main(string[] args){
            long num;
            long i = 0;
            long j = 0;
            int cont = 0;

            Console.Title = "Ejercicio_03";

            Console.Write("Ingrese un numero: ");
            num = long.Parse(Console.ReadLine());

            while (num <= 0){
                Console.Write("ERROR. Ingrese un numero entero positivo: ");
                num = long.Parse(Console.ReadLine());
            }

            while (i ++ < num){
                while (j ++ < i){
                    if (i % j == 0 && cont < 2){
                        if (j == i)
                            Console.WriteLine("{0:#,###}", i);

                        cont ++;
                    }
                }

                cont = 0;
                j = 0;
            }

            Console.ReadKey();
        }
    }
}
