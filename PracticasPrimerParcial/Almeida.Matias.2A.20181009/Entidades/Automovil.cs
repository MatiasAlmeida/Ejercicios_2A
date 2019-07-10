using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        private ConsoleColor color;
        private static int valorHora;

        static Automovil()
        {
            valorHora = 50;
        }

        public Automovil(string patente, ConsoleColor color) : base(patente)
        {
            this.color = color;
        }

        public Automovil(string patente, ConsoleColor color, int valorHora) : this(patente, color)
        {
            Automovil.valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
            return base.ImprimirTicket() + "Color: " + this.color.ToString() + "\n";
        }

        public override bool Equals(object obj)
        {
            return this == (Vehiculo)obj;
        }

        public override string ImprimirTicket()
        {
            TimeSpan horas = DateTime.Now - this.ingreso;
            return this.ConsultarDatos() + "Costo estadia: " + (horas.Hours*valorHora).ToString() + "\n\n";
        }
    }
}
