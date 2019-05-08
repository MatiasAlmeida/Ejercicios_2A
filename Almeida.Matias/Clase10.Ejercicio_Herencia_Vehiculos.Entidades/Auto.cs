using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10.Ejercicio_Herencia_Vehiculos.Entidades
{
    public class Auto : Vehiculo
    {
        protected int _cantidadAsientos;

        public Auto(byte ruedas, string patente, EMarcas marca, int cantAsientos) : base(ruedas: ruedas, patente: patente, marca: marca)
        {
            this._cantidadAsientos = cantAsientos;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        protected override string Mostrar()
        {
            return base.ToString() + " - " + this._cantidadAsientos.ToString();
        }
    }
}
