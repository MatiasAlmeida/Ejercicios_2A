using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo.Parcial.Facil
{
    public class Platano : Fruta
    {
        public string paisOrigen;

        public override bool TieneCarozo { get => false; }
        public string Tipo { get => "Platano"; }
        public string PaisOrigen { get => this.paisOrigen; set => this.paisOrigen = value; }

        public Platano() : base(0, 0)
        {

        }

        public Platano(float peso, ConsoleColor color, string pais) : base(peso, color)
        {
            this.paisOrigen = pais;
        }

        protected override string FrutaToString()
        {
            return base.FrutaToString() + "PAIS DE ORIGEN: " + this.paisOrigen + "\n";
        }

        public override string ToString()
        {
            return this.Tipo + "\n" + this.FrutaToString() + "TIENE CAROZO: " + this.TieneCarozo.ToString() + "\n";
        }
    }
}
