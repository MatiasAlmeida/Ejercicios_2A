using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Entidades.Clase21
{
    public class Alumno : Persona
    {
        private int _legajo;

        public int Legajo
        {
            get { return this._legajo; }
            set { this._legajo = 124235; }
        }

        public override string ToString()
        {
            return this.Legajo.ToString();
        }

        
    }
}
