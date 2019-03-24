using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04{
    class Ejercicio_04{
        static void Main(string[] args){
            short i = 0;
            int j = 0;
            int k = 0; 
            int acum = 0;

            Console.Title = "Ejercicio_04";

            Console.WriteLine("Los primeros 4 numeros perfectos son:");

            while (i < 4){
                j++;

                while (k ++ < j){
                    if (j%k == 0 && k != j && j != 1){
                        acum += k;
                    }
                }

                if (acum == j){
                    Console.WriteLine("{0:#,###}", acum);
                    i ++;
                }

                acum = 0;
                k = 0;
            }

            Console.ReadKey();
        }
    }
}
