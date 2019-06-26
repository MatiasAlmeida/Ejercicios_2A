using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cajon <T>
    {
        private int _capacidad;
        private List<T> _frutas;
        private float _precioUnitario;

        public List<T> Frutas { get { return this._frutas; } }
        public float PrecioTotal
        {
            get
            {
                float aux = 0;
                foreach (T item in this._frutas)
                {
                    aux += this._precioUnitario;
                }

                return aux;
            }
        }

        private Cajon() { this._frutas = new List<T>(); }

        public Cajon(int capacidad) : this()
        {
            this._capacidad = capacidad;
        }

        public Cajon(int capacidad, float precio) : this(capacidad)
        {
            this._precioUnitario = precio;
        }

        public static Cajon<T> operator +(Cajon<T> c, T f)
        {
            if (c._frutas.Count < c._capacidad)
                c._frutas.Add(f);
            else
                throw new CajonLlenoException("No se pueden agregar mas frutas, capacidad maxima alcanzada.");

            return c;
        }

        public override string ToString()
        {
            string aux = null;
            aux = "Capacidad del cajon: " + this._capacidad.ToString() + "\nCantidad de frutas: " + this._frutas.Count
                + "\nPrecio total: " + this.PrecioTotal.ToString();

            foreach (T item in this._frutas)
            {
                aux += item.ToString();
            }

            return aux;
        }
    }
}
