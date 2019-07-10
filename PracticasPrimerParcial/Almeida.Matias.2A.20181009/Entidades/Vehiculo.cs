using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private string patente;

        public string Patente
        {
            get { return this.patente; }
            set {
                if (value.Length == 6)
                    this.patente = value;
                else
                    this.patente = null;
            }
        }

        public abstract string ConsultarDatos();

        public virtual string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder(this.ToString());
            sb.AppendLine(" - Ingreso: " + this.ingreso.ToString());

            return sb.ToString();
        }

        public override string ToString()
        {
            return string.Format("Patente {0}", this.Patente);
        }

        public Vehiculo(string patente)
        {
            this.ingreso = DateTime.Now.AddHours(-3);
            this.Patente = patente;
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1.Patente == v2.Patente && v1.GetType() == v2.GetType();
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}
