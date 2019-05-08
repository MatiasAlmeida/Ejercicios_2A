using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        private short anio;
        private Divisiones division;

        public string AnioDivision
        {
            get { return this.anio.ToString() + "°" + this.division.ToString(); }
        }

        public Alumno(string nombre, string apellido, string documento, short anio, Divisiones division) : base(nombre, apellido, documento)
        {
            this.anio = anio;
            this.division = division;
        }

        public override string ExponerDatos()
        {
            StringBuilder datos = new StringBuilder(base.ExponerDatos());
            datos.Append(" - " + this.AnioDivision);

            return datos.ToString();
        }

        protected override bool ValidarDocumentacion(string doc)
        {
            bool flag = false;

            foreach(char a in doc)
            {
                if(a != '-')
                {
                    if (char.IsDigit(a))
                        flag = true;
                    else
                    {
                        flag = false;
                        break;
                    }
                }
            }

            if (flag == true && doc.Substring(2, 1) != "-" && doc.Substring(6, 1) != "-")
                flag = false;

            return flag;
        }

        /*public prod(string nombre)
        {
            this.Nombre = nombre;
        }

        public prodImpuestos(string nombre, double valor) : base(nombre)
        {
            this.valor = valor;
        }

        public prodImport(prodImpuesto prod, string pais) : base(prod.nombre, prod.valor)
        {
            this.pais = pais;
        }

        public prodExport(prodImport prod, string cliente) : base(prod, prod.pais)
        {
            this.cliente = cliente;
        } LLORO*/
    }
}
