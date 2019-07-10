using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PickUp : Vehiculo
    {
        private string modelo;
        private static int valorHora;

        public override string ConsultarDatos()
        {
            return base.ImprimirTicket() + "Modelo: " + this.modelo + "\n";
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

        static PickUp()
        {
            valorHora = 70;
        }

        public PickUp(string patente, string modelo) : base(patente)
        {
            this.modelo = modelo;
        }

        public PickUp(string patente, string modelo, int valorHora) : this(patente, modelo)
        {
            PickUp.valorHora = valorHora;
        }
    }
}
