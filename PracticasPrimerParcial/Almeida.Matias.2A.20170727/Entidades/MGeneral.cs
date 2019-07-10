using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public class MGeneral : Medico
    {
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

        public MGeneral(string nombre, string apellido) : base(nombre, apellido)
        {

        }
    }
}
