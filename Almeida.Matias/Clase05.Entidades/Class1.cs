using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05.Entidades
{
    public class Tinta
    {
        ConsoleColor _color;
        ETipoTinta _tipoTinta;

        public Tinta() : this(ConsoleColor.Black, ETipoTinta.Comun)
        {
        }

        public Tinta(ConsoleColor color) : this(color, ETipoTinta.Comun)
        {
        }

        public Tinta(ConsoleColor color, ETipoTinta tipoTinta)
        {
            this._tipoTinta = tipoTinta;
            this._color = color;
        }

        private string Mostrar()
        {
            return this._color.ToString() + ", " + this._tipoTinta.ToString();
        }

        public static string Mostrar(Tinta tipoTinta)
        {
            return tipoTinta.Mostrar();
        }

        public static bool operator ==(Tinta tinta1, Tinta tinta2)
        {
            bool flag = false;

            if (tinta1._color == tinta2._color && tinta1._tipoTinta == tinta2._tipoTinta)
                flag = true;

            return flag;
        }

        public static bool operator !=(Tinta tinta1, Tinta tinta2)
        {
            return !(tinta1==tinta2);
        }



    }
}
