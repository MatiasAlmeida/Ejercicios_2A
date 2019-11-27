using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.SP
{
    public class Banana : Fruta
    {
        protected string _paisOrigen;

        public string Nombre { get => "Banana"; }
        public override bool TieneCarozo { get => true; }
        public string PaisOrigen { get => this._paisOrigen; set => this._paisOrigen = value; }

        public Banana(string color, double peso, string paisOrigen) : base(color, peso)
        {
            this._paisOrigen = paisOrigen;
        }

        protected override string FrutaToString()
        {
            return this.Nombre + base.FrutaToString() + "PAIS DE ORIGEN: " + this.PaisOrigen + "\n"
                + "TIENE CAROZO: " + this.TieneCarozo.ToString() + "\n";
        }

        public override string ToString()
        {
            return this.FrutaToString();
        }
    }
}
