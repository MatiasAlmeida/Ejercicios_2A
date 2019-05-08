using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10.Ejercicio_Herencia_Vehiculos.Entidades
{
    public class Moto : Vehiculo
    {
        protected float _cilindrada;

        public Moto(byte ruedas, string patente, EMarcas marca, float cilindrada) : base(ruedas: ruedas, patente: patente, marca:marca)
        {
            this._cilindrada = cilindrada;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        protected override string Mostrar()
        {
            return base.ToString() + " - " + this._cilindrada.ToString();
        }
    }
}
