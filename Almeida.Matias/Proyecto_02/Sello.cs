using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_02
{
    public class Sello
    {
        public static string mensaje;

        public static ConsoleColor color;

        public static string Imprimir() {
            Sello.mensaje = Sello.ArmarFormatoMensaje();
            return Sello.mensaje;
        }

        public static void Borrar() {
            Sello.mensaje = "";
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.color);
            Console.ReadLine();
        }

        private static string ArmarFormatoMensaje()
        {
            int i = 1;
            string cadenita = "";

            while(i++ < Sello.mensaje.Length + 2) 
                cadenita += "*";                

            Sello.mensaje = cadenita + "\n*" + Sello.mensaje + "*\n" + cadenita;

            return Sello.mensaje;
        }
    }
}
