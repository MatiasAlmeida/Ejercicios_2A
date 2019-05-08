using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private List<Alumno> alumnos;
        private short anio;
        private Divisiones division;
        private Profesor profesor;

        public string AnioDivision
        {
            get { return this.anio.ToString() + "°" + this.division.ToString(); }
        }

        private Curso()
        {
            this.alumnos = new List<Alumno>();
        }

        public Curso(short anio, Divisiones division, Profesor profesor) : this()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }

        public static explicit operator string(Curso c)
        {
            StringBuilder datos = new StringBuilder(c.AnioDivision + " - " + c.profesor.ExponerDatos());

            foreach (Alumno item in c.alumnos)
            {
                datos.Append("\n" + item.ExponerDatos());
            }

            return datos.ToString();
        }

        public static bool operator ==(Curso c, Alumno a)
        {
            bool flag = false;

            foreach(Alumno item in c.alumnos)
            {
                if (item == a && item.AnioDivision == a.AnioDivision)
                {
                    flag = true;
                    break;
                }
            }

            return flag;
        }

        public static bool operator !=(Curso c, Alumno a)
        { 
            return !(c == a);
        }

        public static Curso operator +(Curso c, Alumno a)
        {
            if (c != a && c.AnioDivision == a.AnioDivision)
                c.alumnos.Add(a);

            return c;
        }
    }
}
