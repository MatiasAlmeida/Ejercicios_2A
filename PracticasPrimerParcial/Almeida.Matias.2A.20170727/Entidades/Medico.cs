using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Medico : Persona
    {
        private Paciente pacienteActual;
        protected static Random tiempoAleatorio;

        public Paciente AtenderA
        {
            set { this.pacienteActual = value; }
        }

        public virtual string EstaAtendiendoA
        {
            get { return this.pacienteActual.ToString(); }
        }

        protected abstract void Atender();

        protected void FinalizarAtencion()
        {
            Console.WriteLine(this.EstaAtendiendoA);
            this.pacienteActual = null;
        }

        static Medico()
        {
            tiempoAleatorio = new Random();
        }

        public Medico(string nombre, string apellido) : base(nombre, apellido)
        {

        }
    }
}
