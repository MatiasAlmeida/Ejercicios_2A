using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Entidades
{
    public class MEspecialista : Medico
    {
        private Especialidad especialidad;

        public enum Especialidad
        {
            Traumatologo,
            Odontologo
        }

        protected override void Atender()
        {
            Console.WriteLine("Finalizo la atencion.");
            
        }

        public void IniciarAtencion(Paciente p)
        {
            this.Atender();
            Console.WriteLine(p.ToString());
            StreamWriter wr = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"pacientes_atendidos.txt", true);
            wr.WriteLine(p.ToString());
            wr.Close();
        }

        public MEspecialista(string nombre, string apellido, Especialidad e) : base(nombre, apellido)
        {
            this.especialidad = e;
        }


    }
}
