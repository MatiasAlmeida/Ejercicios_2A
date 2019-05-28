using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DepositoDeCocinas
    {
        private int _capacidadMaxima;
        private List<Cocina> _lista;

        public bool Agregar(Cocina a)
        {
            return this + a;
        }

        public DepositoDeCocinas(int capacidad)
        {
            this._lista = new List<Cocina>();
            this._capacidadMaxima = capacidad;
        }

        public static bool operator +(DepositoDeCocinas d, Cocina a)
        {
            bool flag = false;

            if (d._capacidadMaxima > d._lista.Count)
            {
                d._lista.Add(a);
                flag = true;
            }

            return flag;
        }

        private int GetIndice(Cocina a)
        {
            int flag = -1;
            foreach (Cocina item in this._lista)
            {
                if (item == a)
                {
                    flag = this._lista.IndexOf(item);
                    break;
                }
            }

            return flag;
        }

        public static bool operator -(DepositoDeCocinas d, Cocina a)
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

        public bool Remover(Cocina a)
        {
            return this - a;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("\nCapacidad Maxima: {0}", this._capacidadMaxima.ToString());

            foreach (Cocina item in this._lista)
                sb.AppendFormat("\n{0}", item.ToString());

            return sb.ToString();
        }
    }
}
