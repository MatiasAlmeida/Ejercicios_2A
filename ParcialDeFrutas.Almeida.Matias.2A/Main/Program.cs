using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Platano platano = new Platano((float)12.5 , ConsoleColor.Black, "Argentina");
            Manzana manzana = new Manzana((float)25.5, ConsoleColor.DarkBlue, "ManzanitasCORP");
            Cajon<Platano> cajon = new Cajon<Platano>(12, (float)60);

            cajon += platano;
            ((ISerializable)platano).RutaArchivo = "archivo.xml";

            Console.WriteLine(Program.Serializar((ISerializable)platano));
            Console.WriteLine(Program.Deserializar((ISerializable)platano));
            Console.WriteLine(cajon.ToString());
            Console.ReadKey();

        }

        private static bool Deserializar(ISerializable obj)
        {
            return obj.Deserializar();
        }

        private static bool Serializar(ISerializable obj)
        {
            return obj.SerializarXML();
        }
    }
}
