using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10.Ejercicio_Herencia_Vehiculos.Entidades
{
    public class Camion : Vehiculo
    {
        protected float _tara;

        public Camion(byte ruedas, string patente, EMarcas marca, float tara) : base(ruedas:ruedas, patente:patente,marca:marca)
        {
            this._tara = tara;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        protected override string Mostrar()
        {
            return base.ToString() + " - " + this._tara.ToString();
        }
    }
}
