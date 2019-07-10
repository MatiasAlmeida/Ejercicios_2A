using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almeida.Matias._2A
{
    public abstract class Persona
    {
        private string apellido;
        private string nombre;

        public string Apellido
        {
            get { return this.apellido; }
        }

        public string Nombre
        {
            get { return this.nombre; }
        }

        protected abstract string FichaTecnica();

        protected virtual string NombreCompleto()
        {
            return string.Format("{0} {1}", this.Nombre, this.Apellido);
        }

        public Persona(string nombre, string apellido)
        {
            this.apellido = apellido;
            this.nombre = nombre;
        }
    }
}
