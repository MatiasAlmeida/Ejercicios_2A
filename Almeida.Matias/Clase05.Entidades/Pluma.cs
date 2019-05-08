using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05.Entidades
{
    public class Pluma
    {
        private string _Marca;
        private Tinta _Tinta;
        private int _Cantidad;

        public Pluma() : this("sin marca", null, 0)
        {
        }

        public Pluma(string marca) : this(marca, null, 0)
        {
        }

        public Pluma(string marca, Tinta tinta) : this(marca, tinta, 0)
        {
        }

        public Pluma(string marca, Tinta tinta, int cantidad)
        {
            this._Marca = marca;
            this._Tinta = tinta;
            this._Cantidad = cantidad;
        }

        private string Mostrar()
        {
            return this._Marca + ", " + this._Cantidad.ToString() + Tinta.Mostrar(this._Tinta);
        }


        public static implicit operator string(Pluma pluma)
        {
            return pluma.Mostrar();
        }

        /* o tambien
        public static explicit operator string(Pluma pluma)
        {
            return pluma.Mostrar();
        }
        */

        public static Pluma operator +(Pluma pluma, Tinta tinta)
        {
            if (pluma._Tinta == tinta)
                pluma._Cantidad += 10;

            return pluma;
        }

        public static Pluma operator -(Pluma pluma, Tinta tinta)
        {
            if (!(pluma._Tinta == tinta))
                pluma._Cantidad -= 10;

            return pluma;
        }

        public static bool operator ==(Pluma plumaTinta, Tinta tinta)
        {
            return plumaTinta._Tinta == tinta;
        }

        public static bool operator !=(Pluma plumaTinta, Tinta tinta)
        {
            return !(plumaTinta._Tinta == tinta);
        }

    }
}
