using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deposito<T>
    {
        private int _capacidadMaxima;
        private List<T> _lista;

        public bool Agregar(T a)
        {
            return this + a;
        }

        public Deposito(int capacidad)
        {
            this._lista = new List<T>();
            this._capacidadMaxima = capacidad;
        }

        public static bool operator +(Deposito<T> d, T a)
        {
            bool flag = false;

            if (d._capacidadMaxima > d._lista.Count)
            {
                d._lista.Add(a);
                flag = true;
            }

            return flag;
        }

        private int GetIndice(T a)
        {
            int flag = -1;
            foreach (T item in this._lista)
            {
                if (this.Equals(a))
                {
                    flag = this._lista.IndexOf(item);
                    break;
                }
            }

            return flag;
        }

        public static bool operator -(Deposito<T> d, T a)
        {
            bool flag = false;
            int aux = d.GetIndice(a);

            if (aux != -1)
            {
                d._lista.RemoveAt(aux);
                flag = true;
            }

            return flag;
        }

        public bool Remover(T a)
        {
            return this - a;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("\nCapacidad Maxima: {0}", this._capacidadMaxima.ToString());

            foreach (T item in this._lista)
                sb.AppendFormat("\n{0}", item.ToString());

            return sb.ToString();
        }
    }
}
