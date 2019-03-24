using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07{
    class Ejercicio_07{
        static void Main(string[] args){
            int year;
            int i;
            short month;
            short date;
            short days = 0;
            short flag = 0;

            Console.Title = "Ejercicio_07";

            Console.Write("Ingrese el anio en que nacio: ");
            year = int.Parse(Console.ReadLine());

            while (year <= 0){
                Console.Write("ERROR. Los anios no pueden ser negativos. Ingrese nuevamente: ");
                year = int.Parse(Console.ReadLine());
            }

            if (year % 400 == 0 || year % 4 == 0)
                flag = 1;

            Console.Write("Ingrese el mes en que nacio (1 - 12): ");
            month = short.Parse(Console.ReadLine());

            while (month < 1 || month > 12){
                Console.Write("ERROR. Ingrese un mes entre 1 y 12: ");
                month = short.Parse(Console.ReadLine());
            }

            Console.Write("Ingrese la fecha del mes en que nacio (1 - 31): ");
            date = short.Parse(Console.ReadLine());

            switch (month){
                case 1:
                    while (date < 1 || date > 31){
                        Console.Write("ERROR. Enero tiene 31 dias. Ingrese fecha nuevamente: ");
                        date = short.Parse(Console.ReadLine());
                    }

                    break;
                case 2:
                    if (flag == 0){ 
                        while (date < 1 || date > 28){
                            Console.Write("ERROR. Febrero tiene 28 dias. Ingrese fecha nuevamente: ");
                            date = short.Parse(Console.ReadLine());
                        }
                    }
                    else{
                        while (date < 1 || date > 29){
                            Console.Write("ERROR. Febrero tiene 29 dias (anio bisiesto). Ingrese fecha nuevamente: ");
                            date = short.Parse(Console.ReadLine());
                        }
                    }

                    days = 31;

                    break;
                case 3:
                    while (date < 1 || date > 31){
                        Console.Write("ERROR. Marzo tiene 31 dias. Ingrese fecha nuevamente: ");
                        date = short.Parse(Console.ReadLine());
                    }

                    days = 59;

                    break;
                case 4:
                    while (date < 1 || date > 30){
                        Console.Write("ERROR. Abril tiene 30 dias. Ingrese fecha nuevamente: ");
                        date = short.Parse(Console.ReadLine());
                    }

                    days = 90;

                    break;
                case 5:
                    while (date < 1 || date > 31){
                        Console.Write("ERROR. Mayo tiene 31 dias. Ingrese fecha nuevamente: ");
                        date = short.Parse(Console.ReadLine());
                    }

                    days = 120;

                    break;
                case 6:
                    while (date < 1 || date > 30){
                        Console.Write("ERROR. Junio tiene 30 dias. Ingrese fecha nuevamente: ");
                        date = short.Parse(Console.ReadLine());
                    }

                    days = 151;

                    break;
                case 7:
                    while (date < 1 || date > 31){
                        Console.Write("ERROR. Julio tiene 31 dias. Ingrese fecha nuevamente: ");
                        date = short.Parse(Console.ReadLine());
                    }

                    days = 181;

                    break;
                case 8:
                    while (date < 1 || date > 31){
                        Console.Write("ERROR. Agosto tiene 31 dias. Ingrese fecha nuevamente: ");
                        date = short.Parse(Console.ReadLine());
                    }

                    days = 212;

                    break;
                case 9:
                    while (date < 1 || date > 30){
                        Console.Write("ERROR. Septiembre tiene 30 dias. Ingrese fecha nuevamente: ");
                        date = short.Parse(Console.ReadLine());
                    }

                    days = 243;

                    break;
                case 10:
                    while (date < 1 || date > 31){
                        Console.Write("ERROR. Octubre tiene 31 dias. Ingrese fecha nuevamente: ");
                        date = short.Parse(Console.ReadLine());
                    }

                    days = 273;

                    break;
                case 11:
                    while (date < 1 || date > 30){
                        Console.Write("ERROR. Noviembre tiene 30 dias. Ingrese fecha nuevamente: ");
                        date = short.Parse(Console.ReadLine());
                    }

                    days = 304;

                    break;
                case 12:
                    while (date < 1 || date > 31){
                        Console.Write("ERROR. Diciembre tiene 31 dias. Ingrese fecha nuevamente: ");
                        date = short.Parse(Console.ReadLine());
                    }

                    days = 334;

                    break;
                default:
                    break;
            }

            Console.WriteLine("La fecha actual es: {0:dd/MM/yyyy} y Ud. nacio el {1}/{2}/{3}", DateTime.Now, date, month, year);
            i = year;

            while (i++ < DateTime.Now.Year){
                if (i % 400 == 0 || i % 4 == 0)
                    days++;   //son los dias que se agregan por año bisiesto
            }

            Console.WriteLine("Usted ha vivido: {0:#,###} dias", 365*(DateTime.Now.Year - year) + days + date);

            Console.ReadKey();
        }
    }
}
