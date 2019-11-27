using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.SP
{
    public class Durazno : Fruta
    {
        protected int _cantPelusa;

        public string Nombre { get => "Durazno"; }
        public override bool TieneCarozo { get => true; }
        public int CantidadPelusa { get => this._cantPelusa; set => this._cantPelusa = value; }

        public Durazno(string color, double peso, int cantPelusa) : base(color, peso)
        {
            this._cantPelusa = cantPelusa;
        }

        protected override string FrutaToString()
        {
            return this.Nombre + base.FrutaToString() + "CANTIDAD DE PELUSA: " + this.CantidadPelusa + "\n"
                + "TIENE CAROZO: " + this.TieneCarozo.ToString() + "\n";
        }

        public override string ToString()
        {
            return this.FrutaToString();
        }
    }
}
