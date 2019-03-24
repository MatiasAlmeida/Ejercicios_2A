using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05{
    class Ejercicio_05{
        static void Main(string[] args){
            int num;
            int i = 0;
            int j = 0;
            int k;
            long acum1 = 0;
            long acum2 = 0;
            short flag = 0;

            Console.Title = "Ejercicio_05";

            Console.Write("Ingrese un numero entero: ");
            num = int.Parse(Console.ReadLine());

            while (num <= 0){
                Console.Write("ERROR. Ingrese un numero entero positivo: ");
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Los centros numericos del 1 hasta el numero {0:#,###} son:", num);

            while (i++ < num){
                k = i + 1;

                while (j++ < i - 1)
                    acum1 += j;

                while (acum2 <= acum1){
                    acum2 += k;
                    k++;

                    if (acum2 == acum1){
                        Console.WriteLine("{0:#,###}", i);
                        flag = 1;
                    }
                }

                acum1 = 0;
                acum2 = 0;
                j = 0;
            }

            if (flag == 0){
                Console.WriteLine("No se encontraron numeritos jeje");
            }

            Console.ReadKey();
        }
    }
}
