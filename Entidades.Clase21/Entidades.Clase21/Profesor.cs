using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase21
{
    public class Profesor : Persona
    {
        private string _titulo;

        public string Titulo
        {
            get { return this._titulo; }
            set { this._titulo = "Ingeniero"; }
        }

        public override string ToString()
        {
            return this.Titulo;
        }
    }
}
