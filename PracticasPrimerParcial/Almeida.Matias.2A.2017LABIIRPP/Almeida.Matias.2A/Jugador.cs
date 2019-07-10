using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almeida.Matias._2A
{
    public class Jugador : Persona
    {
        private bool esCapitan;
        private int numero;

        public bool EsCapitan
        {
            get { return this.esCapitan; }
            set { this.esCapitan = value; }
        }

        public int Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }

        public override bool Equals(object obj)
        {
            return obj is Jugador && (Jugador)obj == this;
        }

        public override string ToString()
        {
            return this.FichaTecnica();
        }

        protected override string FichaTecnica()
        {
            if (this.EsCapitan)
            {
                return string.Format("{0} {1}, capitán del equipo, camiseta número {2}", this.Nombre, this.Apellido, this.Numero);
            }
            else
            {
                return string.Format("{0} {1} camiseta número {2}", this.Nombre, this.Apellido, this.Numero);
            }
        }

        public Jugador(string nombre, string apellido) : this(nombre, apellido, 0, false)
        {
        }

        public Jugador(string nombre, string apellido, int numero, bool capitan) : base(nombre, apellido)
        {
            this.EsCapitan = capitan;
            this.Numero = numero;
        }

        public static explicit operator int(Jugador jugador)
        {
            return jugador.Numero;
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Nombre == j2.Nombre && j1.Apellido == j2.Apellido && j1.Numero == j2.Numero;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
