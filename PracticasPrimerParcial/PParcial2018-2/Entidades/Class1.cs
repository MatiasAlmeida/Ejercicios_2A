using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private int dni;
        private int edad;
        private string nombre;

        public string Apellido
        {
            get { return ""; }
        }

        public int Dni
        {
            get { return 1; }
        }

        public int Edad
        {
            get { return 2; }
        }

        public string Nombre
        {
            get { return ""; }
        }

        public virtual string Mostrar()
        {
            return "";
        }


    }
}
