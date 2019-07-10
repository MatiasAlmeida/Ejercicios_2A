using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        private int cilindrada;
        private short ruedas;
        private static int valorHora;

        public override string ConsultarDatos()
        {
            return base.ImprimirTicket() + "Cilindrada: " + this.cilindrada.ToString() + "\nRuedas: " + this.ruedas.ToString() + "\n";
        }

        public override bool Equals(object obj)
        {
            return this == (Vehiculo)obj;
        }

        public override string ImprimirTicket()
        {
            TimeSpan horas = DateTime.Now - this.ingreso;
            return this.ConsultarDatos() + "Costo estadia: " + (horas.Hours * valorHora).ToString() + "\n\n";
        }

        static Moto()
        {
            valorHora = 30;
        }

        public Moto(string patente, int cilindrada) : this(patente, cilindrada, 2)
        {
        }

        public Moto(string patente, int cilindrada, short ruedas) : base(patente)
        {
            this.cilindrada = cilindrada;
            this.ruedas = ruedas;
        }

        public Moto(string patente, int cilindrada, short ruedas, int valorHora) : this(patente, cilindrada, ruedas)
        {
            Moto.valorHora = valorHora;
        }
    }
}
