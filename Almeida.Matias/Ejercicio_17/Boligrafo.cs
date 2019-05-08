using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utiles {
    class Boligrafo {
        public const short cantidadTintaMaxima = 100;
        short tinta;
        ConsoleColor color;

        public Boligrafo(short tinta, ConsoleColor color) {
            this.tinta = Boligrafo.GetTinta();
        }

        public static ConsoleColor GetColor() {
            return ConsoleColor.Red;
        }

        public static short GetTinta() {
            return Boligrafo.cantidadTintaMaxima;
        }

        static void SetTinta() {

        }
    }
}
