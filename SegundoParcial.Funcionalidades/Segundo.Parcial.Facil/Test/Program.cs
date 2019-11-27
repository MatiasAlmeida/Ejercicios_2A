using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Segundo.Parcial.Facil;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Cajon<Fruta> cajon = new Cajon<Fruta>(10, 15);
            Manzana m1 = new Manzana(2, ConsoleColor.Red, "man");
            Manzana m2 = new Manzana(3, ConsoleColor.Red, "manz");
            Platano p1 = new Platano(4, ConsoleColor.Yellow, "ecu");
            Platano p2 = new Platano(5, ConsoleColor.Yellow, "ecua");

            cajon += m1;
            cajon += p1;
            cajon += m2;
            cajon += p2;
            Console.WriteLine(cajon.ToString());
            Program.Serializar(m1);
            Program.Deserializar(m1);
            Program.Serializar(cajon);
            Program.Deserializar(cajon);
            Console.ReadKey();
        }

        private static bool Serializar(ISerializable obj)
        {
            return obj.SerializarXML();
        }

        private static bool Deserializar(ISerializable obj)
        {
            return obj.DeserializarXML();
        }
    }
}
