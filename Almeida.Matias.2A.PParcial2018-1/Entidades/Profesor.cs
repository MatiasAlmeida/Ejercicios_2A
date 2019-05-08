using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        private DateTime fechaDeIngreso;

        public Profesor(string nombre, string apellido, string documento)  : base(nombre, apellido, documento)
        { }

        public Profesor(string nombre, string apellido, string documento, DateTime fechaDeIngreso) : base(nombre, apellido, documento)
        {
            this.fechaDeIngreso = fechaDeIngreso;
        }

        public int Antiguedad
        {
            get {
                TimeSpan antiguedad = DateTime.Now - fechaDeIngreso;
                return antiguedad.Days; }
        }

        protected override bool ValidarDocumentacion(string doc)
        {
            return doc.Length == 8;
        }

        public override string ExponerDatos()
        {
            StringBuilder datos = new StringBuilder(base.ExponerDatos());
            datos.Append(" - " + this.Antiguedad);

            return datos.ToString();
        }
    }
}
