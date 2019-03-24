using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01{
    class Program{
        static void Main(string[] args){
            int num = 0;
            short cont = 0;
            short flag1 = 0;
            short flag2 = 0;
            int aux1 = 0;
            int aux2 = 0;
            float prom = 0;
            float acum = 0;

            Console.Title = "Ejercicio_01";

            Console.WriteLine("Ingrese 5 numeros consecutivos:");

            while(cont++ < 5){
               
                num = int.Parse(Console.ReadLine());
                acum += num;

                if (flag1 == 0 || num > aux1) {
                    aux1 = num;
                    flag1 = 1;
                }

                if (flag2 == 0 || num < aux2) {
                    aux2 = num;
                    flag2 = 1;
                }

                prom = acum / cont;          
            }

            Console.WriteLine("{0}{1}", "Promedio: ", prom);
            Console.WriteLine("{0}{1}", "Maximo: ", aux1);
            Console.WriteLine("{0}{1}", "Minimo: ", aux2);
            Console.ReadLine();
        }
    }
}
