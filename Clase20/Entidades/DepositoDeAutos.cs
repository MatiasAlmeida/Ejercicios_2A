using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DepositoDeAutos
    {
        private int _capacidadMaxima;
        private List<Auto> _lista;

        public bool Agregar(Auto a)
        {
            return this + a;
        }

        public DepositoDeAutos(int capacidad)
        {
            this._lista = new List<Auto>();
            this._capacidadMaxima = capacidad;
        }

        public static bool operator +(DepositoDeAutos d, Auto a)
        {
            bool flag = false;

            if (d._capacidadMaxima > d._lista.Count)
            {
                d._lista.Add(a);
                flag = true;
            }
                
            return flag;
        }

        private int GetIndice(Auto a)
        {
            int flag = -1;
            foreach(Auto item in this._lista)
            {
                if (item == a)
                {
                    flag = this._lista.IndexOf(item); 
                    break;
                }
            }

            return flag;
        }

        public static bool operator -(DepositoDeAutos d, Auto a)
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

        public bool Remover(Auto a)
        {
            return this - a;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("\nCapacidad Maxima: {0}", this._capacidadMaxima.ToString());

            foreach(Auto item in this._lista)
                sb.AppendFormat("\n{0}", item.ToString());

            return sb.ToString();
        }

    }
}
